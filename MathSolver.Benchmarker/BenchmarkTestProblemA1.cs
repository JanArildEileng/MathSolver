using MathSolver.Mysolution.Jaei;

namespace MathSolver.Benchmarker;


[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemA1
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
      return  new ProblemA1().Sum(2,2);
    }

}
