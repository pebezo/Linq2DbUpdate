using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using LinqToDB.Data;
using System.Linq;
using LinqToDB;

namespace Linq2DbUpdate
{
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput, warmupCount: 1, targetCount: 10)]
    public class UpdateBenchmarkMySql
    {
        [GlobalSetup]
        public void CreateSqlTable()
        {
            Console.WriteLine("Setup...");
            using (var db = new TestDatabase(ConnectionString, "MySql.Data"))
            {
                Console.WriteLine("Building test table");
                db.Execute(@"                    
                    CREATE TABLE `test`.`TestTable` (
                        Id INT NOT NULL AUTO_INCREMENT,
                        Column01 VARCHAR(100) NULL,
                        Column02 VARCHAR(100) NULL,
                        Column03 VARCHAR(100) NULL,
                        Column04 VARCHAR(100) NULL,
                        Column05 VARCHAR(100) NULL,
                        Column06 VARCHAR(100) NULL,
                        Column07 VARCHAR(100) NULL,
                        Column08 VARCHAR(100) NULL,
                        Column09 VARCHAR(100) NULL,
                        Column10 VARCHAR(100) NULL,
                        Column11 VARCHAR(100) NULL,
                        Column12 VARCHAR(100) NULL,
                        Column13 VARCHAR(100) NULL,
                        Column14 VARCHAR(100) NULL,
                        Column15 VARCHAR(100) NULL,
                        Column16 VARCHAR(100) NULL,
                        Column17 VARCHAR(100) NULL,
                        Column18 VARCHAR(100) NULL,
                        Column19 VARCHAR(100) NULL,
                        Column20 INT NULL,
                        Column21 INT NULL,
                        Column22 INT NULL,
                        Column23 INT NULL,
                        Column24 INT NULL,
                        Column25 INT NULL,
                        Column26 INT NULL,
                        Column27 INT NULL,
                        Column28 INT NULL,
                        Column29 INT NULL,
                        Column30 DATETIME NULL,
                        Column31 DATETIME NULL,
                        Column32 DATETIME NULL,
                        Column33 DATETIME NULL,
                        Column34 DATETIME NULL,
                        Column35 DATETIME NULL,
                        Column36 DATETIME NULL,
                        Column37 DATETIME NULL,
                        Column38 DATETIME NULL,
                        Column39 DATETIME NULL,
                        Column40 TINYINT(1) NULL,
                        Column41 TINYINT(1) NULL,
                        Column42 TINYINT(1) NULL,
                        Column43 TINYINT(1) NULL,
                        Column44 TINYINT(1) NULL,
                        Column45 TINYINT(1) NULL,
                        Column46 TINYINT(1) NULL,
                        Column47 TINYINT(1) NULL,
                        Column48 TINYINT(1) NULL,
                        Column49 TINYINT(1) NULL,
                        Column50 DECIMAL(4,2) NULL,
                        Column51 DECIMAL(4,2) NULL,
                        Column52 DECIMAL(4,2) NULL,
                        Column53 DECIMAL(4,2) NULL,
                        Column54 DECIMAL(4,2) NULL,
                        Column55 DECIMAL(4,2) NULL,
                        Column56 DECIMAL(4,2) NULL,
                        Column57 DECIMAL(4,2) NULL,
                        Column58 DECIMAL(4,2) NULL,
                        Column59 DECIMAL(4,2) NULL,
                    PRIMARY KEY (`Id`));");
            }
        }
        
        [GlobalCleanup]
        public static void DropSqlTable()
        {
            Console.WriteLine("Cleanup...");
            using (var db = new TestDatabase(ConnectionString, "MySql.Data"))
            {
                Console.WriteLine("Dropping test table");
                db.Execute("DROP TABLE `test`.`TestTable`");
            }
        }
        
        [Benchmark(Baseline = true)]
        public void Large_Compiled()
        {
            using (var db = new TestDatabase(ConnectionString, "MySql.Data"))
            {
                compiledQuery(db, Values.BuildTestRecord());
            }
        }

        [Benchmark]
        public void Large_Regular()
        {
            using (var db = new TestDatabase(ConnectionString, "MySql.Data"))
            {
                var record = Values.BuildTestRecord();
                db.GetTable<TestTableNotNull>()
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
        
        private static string ConnectionString => "Server=localhost;Port=3344;Uid=root;Pwd=password;Database=test;SslMode=none;Pooling=True;CharSet=utf8mb4;Convert Zero Datetime=True;";
        
        private static readonly Func<DataConnection, TestTableNotNull, int> compiledQuery 
            = CompiledQuery.Compile((DataConnection ctx, TestTableNotNull record) =>
                ctx.GetTable<TestTableNotNull>()
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