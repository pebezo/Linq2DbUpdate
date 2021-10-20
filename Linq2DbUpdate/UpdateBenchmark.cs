using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SQLite;
using Microsoft.Data.Sqlite;

namespace Linq2DbUpdate
{
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput, warmupCount: 5, targetCount: 50)]
    public class UpdateBenchmark
    {
        readonly SqliteConnection connection = CreateConnection();
        
        [Benchmark(Baseline = true)]
        public void Large_Compiled()
        {
            using (var dc = new DataConnection(new SQLiteDataProvider("Microsoft.Data.Sqlite"), connection))
            {
                compiledQuery(dc, BuildTestRecord());
            }
        }

        [Benchmark]
        public void Large_Regular()
        {
            using (var dc = new DataConnection(new SQLiteDataProvider("Microsoft.Data.Sqlite"), connection))
            {
                var record = BuildTestRecord();
                dc.GetTable<TestTable>()
                    .Where(p => p.Id == record.Id)
                    .Set(i => i.Column01, record.Column01)
                    .Set(i => i.Column02, record.Column02)
                    .Set(i => i.Column03, record.Column03)
                    .Set(i => i.Column04, record.Column04)
                    .Set(i => i.Column05, record.Column05)
                    .Set(i => i.Column06, record.Column06)
                    .Set(i => i.Column07, record.Column07)
                    .Set(i => i.Column08, record.Column08)
                    .Set(i => i.Column09, record.Column09)
                    .Set(i => i.Column10, record.Column10)
                    .Set(i => i.Column11, record.Column11)
                    .Set(i => i.Column12, record.Column12)
                    .Set(i => i.Column13, record.Column13)
                    .Set(i => i.Column14, record.Column14)
                    .Set(i => i.Column15, record.Column15)
                    .Set(i => i.Column16, record.Column16)
                    .Set(i => i.Column17, record.Column17)
                    .Set(i => i.Column18, record.Column18)
                    .Set(i => i.Column19, record.Column19)
                    .Set(i => i.Column20, record.Column20)
                    .Set(i => i.Column21, record.Column21)
                    .Set(i => i.Column22, record.Column22)
                    .Set(i => i.Column23, record.Column23)
                    .Set(i => i.Column24, record.Column24)
                    .Set(i => i.Column25, record.Column25)
                    .Set(i => i.Column26, record.Column26)
                    .Set(i => i.Column27, record.Column27)
                    .Set(i => i.Column28, record.Column28)
                    .Set(i => i.Column29, record.Column29)
                    .Set(i => i.Column30, record.Column30)
                    .Set(i => i.Column31, record.Column31)
                    .Set(i => i.Column32, record.Column32)
                    .Set(i => i.Column33, record.Column33)
                    .Set(i => i.Column34, record.Column34)
                    .Set(i => i.Column35, record.Column35)
                    .Set(i => i.Column36, record.Column36)
                    .Set(i => i.Column37, record.Column37)
                    .Set(i => i.Column38, record.Column38)
                    .Set(i => i.Column39, record.Column39)
                    .Set(i => i.Column40, record.Column40)
                    .Set(i => i.Column41, record.Column41)
                    .Set(i => i.Column42, record.Column42)
                    .Set(i => i.Column43, record.Column43)
                    .Set(i => i.Column44, record.Column44)
                    .Set(i => i.Column45, record.Column45)
                    .Set(i => i.Column46, record.Column46)
                    .Set(i => i.Column47, record.Column47)
                    .Set(i => i.Column48, record.Column48)
                    .Set(i => i.Column49, record.Column49)
                    .Set(i => i.Column50, record.Column50)
                    .Set(i => i.Column51, record.Column51)
                    .Set(i => i.Column52, record.Column52)
                    .Set(i => i.Column53, record.Column53)
                    .Set(i => i.Column54, record.Column54)
                    .Set(i => i.Column55, record.Column55)
                    .Set(i => i.Column56, record.Column56)
                    .Set(i => i.Column57, record.Column57)
                    .Set(i => i.Column58, record.Column58)
                    .Set(i => i.Column59, record.Column59)
                    .Update();
            }
        }

        private static SqliteConnection CreateConnection()
        {
            var connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();
            var cmdText = @"CREATE TABLE TestTable (
                Id INT DEFAULT 0 NOT NULL,
                Column01 CHAR(36) DEFAULT ' ' NOT NULL,
                Column02 CHAR(100) DEFAULT ' ' NOT NULL,
                Column03 CHAR(100) DEFAULT ' ' NOT NULL,
                Column04 CHAR(100) DEFAULT ' ' NOT NULL,
                Column05 CHAR(100) DEFAULT ' ' NOT NULL,
                Column06 CHAR(100) DEFAULT ' ' NOT NULL,
                Column07 CHAR(100) DEFAULT ' ' NOT NULL,
                Column08 CHAR(100) DEFAULT ' ' NOT NULL,
                Column09 CHAR(100) DEFAULT ' ' NOT NULL,
                Column10 CHAR(100) DEFAULT ' ' NOT NULL,
                Column11 CHAR(100) DEFAULT ' ' NOT NULL,
                Column12 CHAR(100) DEFAULT ' ' NOT NULL,
                Column13 CHAR(100) DEFAULT ' ' NOT NULL,
                Column14 CHAR(100) DEFAULT ' ' NOT NULL,
                Column15 CHAR(100) DEFAULT ' ' NOT NULL,
                Column16 CHAR(100) DEFAULT ' ' NOT NULL,
                Column17 CHAR(100) DEFAULT ' ' NOT NULL,
                Column18 CHAR(100) DEFAULT ' ' NOT NULL,
                Column19 CHAR(100) DEFAULT ' ' NOT NULL,
                Column20 CHAR(100) DEFAULT ' ' NOT NULL,
                Column21 CHAR(100) DEFAULT ' ' NOT NULL,
                Column22 CHAR(100) DEFAULT ' ' NOT NULL,
                Column23 CHAR(100) DEFAULT ' ' NOT NULL,
                Column24 CHAR(100) DEFAULT ' ' NOT NULL,
                Column25 CHAR(100) DEFAULT ' ' NOT NULL,
                Column26 CHAR(100) DEFAULT ' ' NOT NULL,
                Column27 CHAR(100) DEFAULT ' ' NOT NULL,
                Column28 CHAR(100) DEFAULT ' ' NOT NULL,
                Column29 CHAR(100) DEFAULT ' ' NOT NULL,
                Column30 CHAR(100) DEFAULT ' ' NOT NULL,
                Column31 CHAR(100) DEFAULT ' ' NOT NULL,
                Column32 CHAR(100) DEFAULT ' ' NOT NULL,
                Column33 CHAR(100) DEFAULT ' ' NOT NULL,
                Column34 CHAR(100) DEFAULT ' ' NOT NULL,
                Column35 CHAR(100) DEFAULT ' ' NOT NULL,
                Column36 CHAR(100) DEFAULT ' ' NOT NULL,
                Column37 CHAR(100) DEFAULT ' ' NOT NULL,
                Column38 CHAR(100) DEFAULT ' ' NOT NULL,
                Column39 CHAR(100) DEFAULT ' ' NOT NULL,
                Column40 CHAR(100) DEFAULT ' ' NOT NULL,
                Column41 CHAR(100) DEFAULT ' ' NOT NULL,
                Column42 CHAR(100) DEFAULT ' ' NOT NULL,
                Column43 CHAR(100) DEFAULT ' ' NOT NULL,
                Column44 CHAR(100) DEFAULT ' ' NOT NULL,
                Column45 CHAR(100) DEFAULT ' ' NOT NULL,
                Column46 CHAR(100) DEFAULT ' ' NOT NULL,
                Column47 CHAR(100) DEFAULT ' ' NOT NULL,
                Column48 CHAR(100) DEFAULT ' ' NOT NULL,
                Column49 CHAR(100) DEFAULT ' ' NOT NULL,
                Column50 CHAR(100) DEFAULT ' ' NOT NULL,
                Column51 CHAR(100) DEFAULT ' ' NOT NULL,
                Column52 CHAR(100) DEFAULT ' ' NOT NULL,
                Column53 CHAR(100) DEFAULT ' ' NOT NULL,
                Column54 CHAR(100) DEFAULT ' ' NOT NULL,
                Column55 CHAR(100) DEFAULT ' ' NOT NULL,
                Column56 CHAR(100) DEFAULT ' ' NOT NULL,
                Column57 CHAR(100) DEFAULT ' ' NOT NULL,
                Column58 CHAR(100) DEFAULT ' ' NOT NULL,
                Column59 CHAR(100) DEFAULT ' ' NOT NULL
                )";
            var cmd = new SqliteCommand(cmdText, connection);
            cmd.ExecuteNonQuery();
            return connection;
        }
        
        private static TestTable BuildTestRecord() => new TestTable
        {
            Id = 1,
            Column01 = "value for c01",
            Column02 = "value for c02",
            Column03 = "value for c03",
            Column04 = "value for c04",
            Column05 = "value for c05",
            Column06 = "value for c06",
            Column07 = "value for c07",
            Column08 = "value for c08",
            Column09 = "value for c09",
            Column10 = "value for c10",
            Column11 = "value for c11",
            Column12 = "value for c12",
            Column13 = "value for c13",
            Column14 = "value for c14",
            Column15 = "value for c15",
            Column16 = "value for c16",
            Column17 = "value for c17",
            Column18 = "value for c18",
            Column19 = "value for c19",
            Column20 = "value for c10",
            Column21 = "value for c21",
            Column22 = "value for c22",
            Column23 = "value for c23",
            Column24 = "value for c24",
            Column25 = "value for c25",
            Column26 = "value for c26",
            Column27 = "value for c27",
            Column28 = "value for c28",
            Column29 = "value for c29",
            Column30 = "value for c30",
            Column31 = "value for c31",
            Column32 = "value for c32",
            Column33 = "value for c33",
            Column34 = "value for c34",
            Column35 = "value for c35",
            Column36 = "value for c36",
            Column37 = "value for c37",
            Column38 = "value for c38",
            Column39 = "value for c39",
            Column40 = "value for c40",
            Column41 = "value for c41",
            Column42 = "value for c42",
            Column43 = "value for c43",
            Column44 = "value for c44",
            Column45 = "value for c45",
            Column46 = "value for c46",
            Column47 = "value for c47",
            Column48 = "value for c48",
            Column49 = "value for c49",
            Column50 = "value for c50",
            Column51 = "value for c51",
            Column52 = "value for c52",
            Column53 = "value for c53",
            Column54 = "value for c54",
            Column55 = "value for c55",
            Column56 = "value for c56",
            Column57 = "value for c57",
            Column58 = "value for c58",
            Column59 = "value for c59",
        };
        
        private static readonly Func<DataConnection, TestTable, int> compiledQuery 
            = CompiledQuery.Compile((DataConnection ctx, TestTable record) =>
                ctx.GetTable<TestTable>()
                    .Where(i => i.Id == record.Id)
                    .Set(i => i.Column01, record.Column01)
                    .Set(i => i.Column02, record.Column02)
                    .Set(i => i.Column03, record.Column03)
                    .Set(i => i.Column04, record.Column04)
                    .Set(i => i.Column05, record.Column05)
                    .Set(i => i.Column06, record.Column06)
                    .Set(i => i.Column07, record.Column07)
                    .Set(i => i.Column08, record.Column08)
                    .Set(i => i.Column09, record.Column09)
                    .Set(i => i.Column10, record.Column10)
                    .Set(i => i.Column11, record.Column11)
                    .Set(i => i.Column12, record.Column12)
                    .Set(i => i.Column13, record.Column13)
                    .Set(i => i.Column14, record.Column14)
                    .Set(i => i.Column15, record.Column15)
                    .Set(i => i.Column16, record.Column16)
                    .Set(i => i.Column17, record.Column17)
                    .Set(i => i.Column18, record.Column18)
                    .Set(i => i.Column19, record.Column19)
                    .Set(i => i.Column20, record.Column20)
                    .Set(i => i.Column21, record.Column21)
                    .Set(i => i.Column22, record.Column22)
                    .Set(i => i.Column23, record.Column23)
                    .Set(i => i.Column24, record.Column24)
                    .Set(i => i.Column25, record.Column25)
                    .Set(i => i.Column26, record.Column26)
                    .Set(i => i.Column27, record.Column27)
                    .Set(i => i.Column28, record.Column28)
                    .Set(i => i.Column29, record.Column29)
                    .Set(i => i.Column30, record.Column30)
                    .Set(i => i.Column31, record.Column31)
                    .Set(i => i.Column32, record.Column32)
                    .Set(i => i.Column33, record.Column33)
                    .Set(i => i.Column34, record.Column34)
                    .Set(i => i.Column35, record.Column35)
                    .Set(i => i.Column36, record.Column36)
                    .Set(i => i.Column37, record.Column37)
                    .Set(i => i.Column38, record.Column38)
                    .Set(i => i.Column39, record.Column39)
                    .Set(i => i.Column40, record.Column40)
                    .Set(i => i.Column41, record.Column41)
                    .Set(i => i.Column42, record.Column42)
                    .Set(i => i.Column43, record.Column43)
                    .Set(i => i.Column44, record.Column44)
                    .Set(i => i.Column45, record.Column45)
                    .Set(i => i.Column46, record.Column46)
                    .Set(i => i.Column47, record.Column47)
                    .Set(i => i.Column48, record.Column48)
                    .Set(i => i.Column49, record.Column49)
                    .Set(i => i.Column50, record.Column50)
                    .Set(i => i.Column51, record.Column51)
                    .Set(i => i.Column52, record.Column52)
                    .Set(i => i.Column53, record.Column53)
                    .Set(i => i.Column54, record.Column54)
                    .Set(i => i.Column55, record.Column55)
                    .Set(i => i.Column56, record.Column56)
                    .Set(i => i.Column57, record.Column57)
                    .Set(i => i.Column58, record.Column58)
                    .Set(i => i.Column59, record.Column59)
                    .Update());
    }
}