
namespace MathSolver.Mysolution.Jaei
{
    public class Primes
    {
        public static List<long> GetPrimeFactorsInNumber(long number)
        {
            var primeList = new List<long> { };

            long primeCandidate = 2;
            while (number % primeCandidate == 0)
            {
                primeList.Add(primeCandidate);
                number /= primeCandidate;
            }

            primeCandidate = 3;
            while (number >= primeCandidate)
            {
                while (number % primeCandidate == 0)
                {
                    primeList.Add(primeCandidate);
                    number /= primeCandidate;
                }
                primeCandidate += 2;
            }
            return primeList;
        }
    }
}
