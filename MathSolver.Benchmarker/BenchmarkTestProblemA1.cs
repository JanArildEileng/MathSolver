namespace MathSolver.Benchmarker;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemA1
{

    [Benchmark(Description ="jaei")]
    public int JaeiSolution()
    {
      return  new MathSolver.Mysolution.Jaei.ProblemA1().Sum(2,2);
    }


    [Benchmark(Description = "Gordon")]
    public int GordonSolution()
    {
        return new MathSolver.Mysolution.Gordon.GordonsProblemA1Solver().Sum(2, 2);
    }

}
