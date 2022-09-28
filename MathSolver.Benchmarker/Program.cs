
using MathSolver.Benchmarker;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, BenchmarkRunner !");

switch(args[0])
{

    case "ProblemE005": BenchmarkRunner.Run<BenchmarkTestProblemE005>(); break;
   

}
