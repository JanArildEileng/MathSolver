
using MathSolver.Benchmarker;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, BenchmarkRunner !");

switch(args[0])
{
 
    case "ProblemE001":
        BenchmarkRunner.Run<BenchmarkTestProblemE001>(); break;



}
