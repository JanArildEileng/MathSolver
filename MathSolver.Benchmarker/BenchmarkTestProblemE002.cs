namespace MathSolver.Benchmarker;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public  class BenchmarkTestProblemE002
{
    [Benchmark(Description = "jaei")]
    public long JaeiSolution()
    {
        return new Mysolution.Jaei.E002EvenFibonaccinumbers().SumEven(4000000);
    }

    [Benchmark(Description = "Oist_Slow_IterativeUsingGoldenRatioFormula")]
    public long OistSlowSolution()
    {
        return new Mysolution.Oist.E001EvenFibonacciNumbersIterativeUsingGoldenRatioFormula_Slow().SumEven(4000000);
    }

    [Benchmark(Description = "Oist_Fast_SimpleIterativeSum")]
    public long OistFastSolution()
    {
        return new Mysolution.Oist.E001EvenFibonacciNumbersSimpleIterativeSum_Fast().SumEven(4000000);
    }

    [Benchmark(Description = "Oist_Medium_GoldenRatioFormulaForSum")]
    public long OisMediumSolution()
    {
        return new Mysolution.Oist.E001EvenFibonacciNumbersUsingGoldenRatioFormulaForSum_Medium().SumEven(4000000);
    }

    /*legg til flere benchmark her */


}
