using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Jaei
{
    public class E003Largestprimefactor : IProblemE003
    {
        public long LargestPrime(long number)
        {
        
            return Primes.GetPrimeFactorsInNumber(number).Max();
        }
    }
}
