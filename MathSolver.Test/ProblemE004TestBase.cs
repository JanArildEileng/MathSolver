
namespace MathSolver.Test;

abstract public class ProblemE004TestBase
{
    protected IProblemE004 sut;

    //TODO
    // Lag Sub-klasse med  konstruktor som initierer 'sut' (med din egen implementasjon av IProblemA1)


    [Fact]
    [Trait("IProblemE004", "")]
    public void ExampleTest()
    {
        Assert.Equal(9009, sut.largestPalindrome(100));
    }

    [Fact]
    [Trait("IProblemE004", "")]
    public void SolutionTest()
    {
        var result = sut.largestPalindrome(1000);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(XX.ToString()))
        byte[] expectedBytes = { 85, 210, 100, 248, 103, 27, 80, 181, 219, 175, 250, 86, 209, 238, 113, 159, 212, 41, 232, 244 };

        Assert.Equal(expectedBytes, hashedResult);
    }

}