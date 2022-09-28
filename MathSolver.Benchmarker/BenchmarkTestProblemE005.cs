namespace MathSolver.Benchmarker;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE005
{

    [Benchmark(Description ="jaei")]
    public long JaeiSolution()
    {
        return new MathSolver.Mysolution.Jaei.E005Smallestmultiple().SmallestNumberDividedByAllNumbers(20);
    }

}
