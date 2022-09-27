namespace MathSolver.Benchmarker;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE003
{

    [Benchmark(Description ="jaei")]
    public long JaeiSolution()
    {
      return  new MathSolver.Mysolution.Jaei.E003Largestprimefactor().LargestPrime(600851475143);
    }



}
