using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Jaei
{
    public class E005Smallestmultiple : IProblemE005
    {
        public long SmallestNumberDividedByAllNumbers(int UpToNumber)
        {
            long[] maxCountOfPrimNumber = new long[UpToNumber + 1];


            for (int i = 2; i <= UpToNumber; i++)
            {
                var group = Primes.GetPrimeFactorsInNumber(i).GroupBy(e => e);

                foreach (var g in group)
                {
                    if (maxCountOfPrimNumber[g.Key] < g.Count())
                        maxCountOfPrimNumber[g.Key] = g.Count();
                }
            }


            long smallestNumber = 1;
            for (int i = 2; i <= UpToNumber; i++)
            {
                for (int ii = 0; ii < maxCountOfPrimNumber[i]; ii++)
                    smallestNumber *= i;
            }

            return smallestNumber;

        }
    }
}
