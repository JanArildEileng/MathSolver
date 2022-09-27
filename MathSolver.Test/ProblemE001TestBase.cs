
namespace MathSolver.Test;

abstract public class ProblemE001TestBase
{
    protected IProblemE001 sut;


    [Fact]
    [Trait("ProblemE001", "")]
    public void ExampleTest()
    {
        Assert.Equal(23, sut.Sum(below: 10));
    }

   

    [Fact]
    [Trait("ProblemE001", "")]
    public void MyTest()
    {
        var result = sut.Sum(below: 1000);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(XX.ToString()))
        byte[] expectedBytes = { 118, 66, 196, 194, 226, 75, 23, 110, 212, 66, 21, 62, 48, 151, 232, 25, 191, 92, 168, 14 };

        Assert.Equal(expectedBytes, hashedResult);
    }

}