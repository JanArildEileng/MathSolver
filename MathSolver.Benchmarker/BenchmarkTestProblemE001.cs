using MathSolver.Mysolution.Jaei;
using MathSolver.Mysolution.Oist;
using soa = MathSolver.Mysolution.SOA;

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

    [Benchmark(Description = "gali")]
    public int GaliSolution()
    {
        return new Mysolution.gali.E001Multiplesof3and5().Sum(below: 1000);
    }

    [Benchmark(Description = "tgje")]
    public int TGJESolution()
    {
        return new MathSolver.Mysolution.tgje.E001Multiplesof3and5().Sum(below: 1000);
    }

    [Benchmark(Description = "Oist")]
    public int OistSolution()
    {
        return new E001MultiplesOf3And5UsingArithemeticSeriesSum().Sum(below: 1000);
    }

    [Benchmark(Description = "SOA")]
    public int SOASolution()
    {
        return new soa.E001MultiplesOf3And5UsingArithemeticSeriesSum().Sum(below: 1000);
    }
}
