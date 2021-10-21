using System;
using BenchmarkDotNet.Running;

namespace Linq2DbUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            // To run this benchmark you need Docker installed, from the command line run:
            // docker-compose up --build
            //var summary = BenchmarkRunner.Run<UpdateBenchmarkMySql>();
            
            var summary = BenchmarkRunner.Run<UpdateBenchmarkSqlite>();
   
            Console.WriteLine();
            Console.WriteLine("Done.");
        }
    }
}