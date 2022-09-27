
namespace MathSolver.Test;

abstract public class ProblemE003TestBase
{
    protected IProblemE003 sut;

    //TODO
    // Lag Sub-klasse med  konstruktor som initierer 'sut' (med din egen implementasjon av IProblemE003)


    [Fact]
    [Trait("ProblemE003", "")]
    public void ExampleTest()
    {
        ///The prime factors of 13195 are 5, 7, 13 and 29.
        Assert.Equal(29, sut.LargestPrime(13195));
    }

    [Fact]
    [Trait("ProblemE003", "")]
    public void SolutionTest()
    {
        var result = sut.LargestPrime(600851475143);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(XX.ToString()))
        byte[] expectedBytes = { 160, 92, 177, 115, 193, 186, 28, 106, 227, 11, 207, 94, 219, 213, 213, 225, 149, 102, 231, 100 };

        Assert.Equal(expectedBytes, hashedResult);
    }

}