using System;
using BenchmarkDotNet.Running;

namespace Linq2DbUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<UpdateBenchmark>();
   
            Console.WriteLine();
            Console.WriteLine("Done.");
        }
    }
}