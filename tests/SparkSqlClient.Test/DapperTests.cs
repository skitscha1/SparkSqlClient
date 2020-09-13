﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SparkSqlClient;
using SparkThrift.Test.Fixtures;
using Xunit;

namespace SparkThrift.Test
{
    public class TypeRainbow
    {
        public static string[] TableColumns = new[]
        {
            "myBigInt BIGINT NOT NULL",
            "myInt INT NOT NULL",
            "mySmallInt SMALLINT NOT NULL",
            "myTinyInt TINYINT NOT NULL",
            "myBoolean BOOLEAN NOT NULL",
            "myDouble Double NOT NULL",
            "myFloat FLOAT NOT NULL",
            "myDecimal DECIMAL(10, 2) NOT NULL",
            "myString STRING NOT NULL",
            "myDate DATE NOT NULL",
            "myTimestamp TIMESTAMP NOT NULL",
            "myBinary BINARY NOT NULL",
            "myArray ARRAY<STRING> NOT NULL",
            "myMap MAP<STRING, INT> NOT NULL",
        };

        public long MyBigInt { get; set; }
        public int MyInt { get; set; }
        public Int16 MySmallInt { get; set; }
        public byte MyTinyInt { get; set; }
        public bool MyBoolean { get; set; }
        public double MyDouble { get; set; }
        public float MyFloat { get; set; }
        public decimal MyDecimal { get; set; }
        public string MyString { get; set; }
        public DateTime MyDate { get; set; }
        public DateTime MyTimestamp { get; set; }
        public byte[] MyBinary { get; set; }
        public string MyArray { get; set; }
        public string MyMap { get; set; }
    }

    public class DapperTests : IClassFixture<ConfigurationFixture>, IClassFixture<DataFactoryFixture>
    {
        public ConfigurationFixture Config { get; }
        public DataFactoryFixture DataFactory { get; }

        public DapperTests(ConfigurationFixture config, DataFactoryFixture dataFactory)
        {
            Config = config;
            DataFactory = dataFactory;
        }

        [Fact]
        public async Task WhenDapperShouldExecute()
        {
            var date = new DateTime(2055, 3, 1, 21, 33, 43, 432);

            var table = DataFactory.TableName();
            await using var conn = new SparkConnection(Config.ConnectionString);
            await conn.OpenAsync();
            await DataFactory.DropAndCreateTable(conn, table, TypeRainbow.TableColumns);
            await conn.ExecuteAsync($@"INSERT INTO {table} VALUES 
                    (
                        @MyBigInt, 
                        @MyInt, 
                        @MySmallInt, 
                        @MyTinyInt, 
                        @MyBoolean,
                        @MyDouble, 
                        @MyFloat, 
                        @MyDecimal,
                        @MyString,
                        @MyDate,
                        @MyTimestamp,
                        @MyBinary,
                        array('AAA', 'BBB', 'CCC'),
                        map('AAA', 1, 'BBB', 2, 'CCC', 3)
                    )", new TypeRainbow()
            {
                MyBigInt = Int64.MaxValue,
                MyInt = Int32.MaxValue,
                MySmallInt = Int16.MaxValue,
                MyTinyInt = Byte.MaxValue,
                MyBoolean = true,
                MyDouble = 99999999.99d,
                MyFloat = 99999999.99f,
                MyDecimal = 99999999.99m,
                MyString = "AAA",
                MyDate = date,
                MyTimestamp = date,
                MyBinary = new byte[] {0x48, 0x65, 0x6c, 0x6c, 0x6f}
            });

            var results = await conn.QueryAsync<TypeRainbow>($"SELECT * FROM {table}");

            var result = Assert.Single(results);

            Assert.Equal(Int64.MaxValue, result.MyBigInt);
            Assert.Equal(Int32.MaxValue, result.MyInt);
            Assert.Equal(Int16.MaxValue, result.MySmallInt);
            Assert.Equal(Byte.MaxValue, result.MyTinyInt);
            Assert.True(result.MyBoolean);
            Assert.Equal(99999999.99d, result.MyDouble);
            Assert.Equal(99999999.99f, result.MyFloat);
            Assert.Equal(99999999.99m, result.MyDecimal);
            Assert.Equal("AAA", result.MyString);
            Assert.Equal(date.Date, result.MyDate);
            Assert.Equal(date, result.MyTimestamp);
            Assert.Equal(new byte[] {0x48, 0x65, 0x6c, 0x6c, 0x6f}, result.MyBinary);
            Assert.Equal(@"[""AAA"",""BBB"",""CCC""]", result.MyArray);
            Assert.Equal(@"{""AAA"":1,""BBB"":2,""CCC"":3}", result.MyMap);
        }

        [Fact]
        public async Task WhenDapperShouldExecuteLongRunningQuery()
        {
            await using var conn = new SparkConnection(Config.ConnectionString);
            await conn.OpenAsync();

            var result = await conn.QueryFirstAsync<int>("SELECT sleep(60000)");

            Assert.Equal(60000, result);
        }

    }
}
