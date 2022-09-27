using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Jaei
{
    public class E002EvenFibonaccinumbers : IProblemE002
    {
        public long SumEven(long below)
        {
            Fibonacci fibonacci = new Fibonacci();
            return fibonacci.Iterator(below).Where(e => e.Even()).Sum();
        }
    }
}
