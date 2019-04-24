using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetPractice
{
    [Config(typeof(BenchmarkConfig))]
    public class EnumerableToXxxBenchmark
    {
        private IEnumerable<int> _numbers;
        private IEnumerable<string> _texts;

        [GlobalSetup]
        public void Initialize()
        {
            _numbers = Enumerable.Range(1, 10000000);
            _texts = Enumerable.Repeat("txt", 10000000);
        }

        [Benchmark(Baseline = true)]
        public int NumbersToArray()
        {
            var unused = _numbers.ToArray();
            return 0;
        }

        [Benchmark]
        public int NumbersToList()
        {
            var unused = _numbers.ToList();
            return 0;
        }

        [Benchmark]
        public int TextsToArray()
        {
            var unused = _texts.ToArray();
            return 0;
        }

        [Benchmark]
        public int TextsToList()
        {
            var unused = _texts.ToList();
            return 0;
        }
    }
}
