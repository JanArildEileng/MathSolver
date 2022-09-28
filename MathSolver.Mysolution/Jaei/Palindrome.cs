namespace MathSolver.Mysolution.Jaei;

public class Palindrome
{
    public static bool IsPalindrome(long number)
    {
        string s = number.ToString();
        int len = s.Length;

        for (int i = 0; i < len / 2; i++)
        {
            if (s[i] != s[len - i - 1]) return false;
        }

        return true;
    }
}
