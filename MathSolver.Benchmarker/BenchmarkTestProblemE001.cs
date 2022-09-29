using MathSolver.Mysolution.Jaei;

namespace MathSolver.Benchmarker;


[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE001
{
    [Benchmark(Description ="jaei")]
    public int JaeiSolution()
    {
      return  new E001Multiplesof3and5().Sum(below: 1000); 
    }

    [Benchmark(Description = "tgje")]
    public int TGJESolution()
    {
        return new MathSolver.Mysolution.tgje.E001Multiplesof3and5().Sum(below: 1000);
    }
}
