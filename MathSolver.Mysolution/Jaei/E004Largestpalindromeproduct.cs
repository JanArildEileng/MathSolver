using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Jaei
{
    public class E004Largestpalindromeproduct : IProblemE004
    {
        public long largestPalindrome(long below)
        {
           long largestpalindromeFound = -1;

            for (long i1 = below - 1; i1 > 0; i1--)
            {
                if (i1 * i1 < largestpalindromeFound) break;

                for (long i2 = i1; i2 > 0; i2--)
                {
                    long currentProduct = i1 * i2;
                    if (currentProduct > largestpalindromeFound)
                    {
                        if (Palindrome.IsPalindrome(currentProduct))
                            largestpalindromeFound = currentProduct;
                    }
                    else
                        break;
                }
            }

            return largestpalindromeFound;
        }

    }
}
