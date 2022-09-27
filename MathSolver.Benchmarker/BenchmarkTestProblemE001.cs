using MathSolver.Mysolution.Jaei;

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

}
