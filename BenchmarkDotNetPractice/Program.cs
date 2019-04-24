using BenchmarkDotNet.Running;

namespace BenchmarkDotNetPractice
{
    internal class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<EnumerableToXxxBenchmark>();
        }
    }
}
