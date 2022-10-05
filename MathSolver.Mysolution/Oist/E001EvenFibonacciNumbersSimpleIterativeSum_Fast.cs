using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Oist
{
    public class E001EvenFibonacciNumbersSimpleIterativeSum_Fast : IProblemE002
    {
        public long SumEven(long below)
        {
            // Every 3rd Fibonacci number is even, because the sum of two odd numbers is always even, and the sum of an odd and even number is always odd
            long fibN = 2;
            long fibN1 = 3;
            long fibN2 = 5;
            long sumOfEvenFibonaccis = 0;
            while (fibN < below)
            {
                sumOfEvenFibonaccis += fibN;
                fibN = fibN1 + fibN2;
                fibN1 = fibN2 + fibN;
                fibN2 = fibN + fibN1;
            }

            return sumOfEvenFibonaccis;
        }
    }
}
