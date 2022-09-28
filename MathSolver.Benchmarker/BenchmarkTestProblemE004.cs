namespace MathSolver.Benchmarker;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE004
{

    [Benchmark(Description ="jaei")]
    public long JaeiSolution()
    {
        return new MathSolver.Mysolution.Jaei.E004Largestpalindromeproduct().largestPalindrome(1000);
    }

}
