using MathSolver.Mysolution.Jaei;
using MathSolver.Mysolution.Oist;

namespace MathSolver.Benchmarker;


[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE001
{

    [Benchmark]
    public int Dummy()
    {
        var a = 1 + 1;

        return a;
    }

    [Benchmark(Description ="jaei")]
    public int JaeiSolution()
    {
        return  new E001Multiplesof3and5().Sum(below: 1000);
    }

    [Benchmark(Description = "Oist")]
    public int OistSolution()
    {
        return new E001MultiplesOf3And5UsingArithemeticSeriesSum().Sum(below: 1000);
    }
}
