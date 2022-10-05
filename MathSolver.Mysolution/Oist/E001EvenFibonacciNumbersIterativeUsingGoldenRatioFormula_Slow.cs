using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Oist
{
    public class E001EvenFibonacciNumbersIterativeUsingGoldenRatioFormula_Slow : IProblemE002
    {
        private const double GoldenRatio = 1.61803398874989;
        private const double SqrRoot5 = 2.23606797749979;

        public long SumEven(long below)
        {
            // Every 3rd Fibonacci number is even, because the sum of two odd numbers is always even, and the sum of an odd and even number is always odd
            // Fib 0 = 0
            // Fib 1 = 1
            // Fib 2 = 1
            // Fib 3 = 2
            // Fib 4 = 3

            long fibN = 2;
            long sumOfEvenFibonaccis = 0;
            int n = 3;
            while (fibN < below)
            {
                sumOfEvenFibonaccis += fibN;
                // Every 3rd Fibonacci is even, so find the next even one
                n += 3;
                fibN = FibonacciN(n);
            }

            return sumOfEvenFibonaccis;
        }

        private static long FibonacciN(int n)
        {
            // Using the closed form formula for Fibonacci number N involving the golden ratio (1,61803398874989...)
            return (long) Math.Round((Math.Pow(GoldenRatio, n) - Math.Pow(1 - GoldenRatio, n)) / SqrRoot5);
        }
    }
}
