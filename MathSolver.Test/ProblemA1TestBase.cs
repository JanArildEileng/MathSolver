
namespace MathSolver.Test;

abstract public class ProblemA1TestBase
{
    protected IProblemA1 problemA1;

    //TODO
    // Lag Sub-klasse med  konstruktor som initierer 'sut' (med din egen implementasjon av IProblemA1)


    [Fact]
    [Trait("ProblemA1", "")]
    public void ExampleTest()
    {
        Assert.Equal(2, problemA1.Sum(1, 1));
    }

    [Fact]
    [Trait("ProblemA1", "")]
    public void SolutionTest()
    {
        var result = problemA1.Sum(2, 2);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(4.ToString()))
        byte[] expectedBytes = { 27, 100, 83, 137, 36, 115, 164, 103, 208, 115, 114, 212, 94, 176, 90, 188, 32, 49, 100, 122 };

        Assert.Equal(expectedBytes, hashedResult);
    }

}