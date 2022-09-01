using MathSolver.Mysolution.Jaei;

namespace MathSolver.Test;

public class ProblemA1Test
{
    IProblemA1 problemA1;

    public ProblemA1Test()
    {
        problemA1 = new ProblemA1();

    }
    [Fact]
    [Trait("ProblemA1", "")]
    public void ExampleTest()
    {
        var result = problemA1.Sum(1, 1);
        Assert.Equal(result, problemA1.Sum(1, 1));
    }

    [Fact]
    [Trait("ProblemA1", "")]
    public void MyTest()
    {
        var result = problemA1.Sum(2, 2);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(4.ToString()))
        byte[] expectedBytes = { 27, 100, 83, 137, 36, 115, 164, 103, 208, 115, 114, 212, 94, 176, 90, 188, 32, 49, 100, 122 };

        Assert.Equal(expectedBytes, hashedResult);
    }

}