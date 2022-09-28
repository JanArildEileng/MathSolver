
namespace MathSolver.Test;

abstract public class ProblemE005TestBase
{
    protected IProblemE005 sut;

    //TODO
    // Lag Sub-klasse med  konstruktor som initierer 'sut' (med din egen implementasjon av IProblemE005)


    [Fact]
    [Trait("ProblemE005", "")]
    public void ExampleTest()
    {
        Assert.Equal(2520, sut.SmallestNumberDividedByAllNumbers(10));
    }

    [Fact]
    [Trait("ProblemE005", "")]
    public void SolutionTest()
    {
        var result = sut.SmallestNumberDividedByAllNumbers(20);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(xx.ToString()))
        byte[] expectedBytes = { 71, 142, 201, 82, 209, 134, 50, 159, 130, 93, 180, 238, 121, 120, 227, 29, 212, 45, 230, 34 };


        Assert.Equal(expectedBytes, hashedResult);
    }

}