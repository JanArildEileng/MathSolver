using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Oist
{
    public class E001EvenFibonacciNumbersUsingGoldenRatioFormulaForSum_Medium : IProblemE002
    {
        private const double GoldenRatio = 1.61803398874989;
        private const double SqrRoot5 = 2.23606797749979;

        public long SumEven(long below)
        {
            if (below <= 2) return 0;

            // Find n, where F(n) is largest Fibonacci <= below
            int n = EstimateN(below);

            return SumOfEvens(n);
        }

        private static int EstimateN(long below)
        {
            int n;
            // Find first estimate of n using the first part of the closed formula for Fibonacci number N, F(n) = (g^n - (1-g)^n)/Sqrt(5) where g is the golden ratio
            double nDbl = Math.Log(below * SqrRoot5) / Math.Log(GoldenRatio);

            double nRounded = 0;
            double abs = 0;
            if (below <= 144)
            {
                nRounded = Math.Round(nDbl);
                abs = Math.Abs(nRounded - nDbl);
            }

            if (below <= 34 && abs < 0.05)
                n = (int) nRounded;
            else if (below <= 144 && abs < 0.0005)
                n = (int) nRounded;
            else
            {
                var nInt = Math.Floor(nDbl);
                if (Math.Abs(nDbl - nInt) < 0.00001)
                    n = (int) Math.Round(nDbl);
                else
                    n = (int) nInt;
            }

            return n;
        }

        private static long SumOfEvens(int n)
        {
            // Using self derived closed form formula for the sum of all even Fibonacci numbers <= Fibonacci number n
            int m = n % 3;
            n -= m;
            return (long)Math.Round((Math.Pow(GoldenRatio, n+3) - Math.Pow(1 - GoldenRatio, n+3) - GoldenRatio * SqrRoot5) / (5 + SqrRoot5));
        }
    }
}
