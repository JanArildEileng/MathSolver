namespace MathSolver.Benchmarker;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE002
{

    [Benchmark(Description ="jaei")]
    public long JaeiSolution()
    {
      return  new MathSolver.Mysolution.Jaei.E002EvenFibonaccinumbers().SumEven(4000000);
    }

    /*legg til flere benchmark her */
   

}
