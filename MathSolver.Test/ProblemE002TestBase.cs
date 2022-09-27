
namespace MathSolver.Test;

abstract public class ProblemE002TestBase
{
    protected IProblemE002 sut;

    //TODO
    // Lag Sub-klasse med  konstruktor som initierer 'sut' (med din egen implementasjon av IProblemA1)


    [Fact]
    [Trait("ProblemE002", "")]
    public void ExampleTest()
    {
        var list = new List<long> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

        var sumTest = list.Where(e => e % 2 == 0).Sum();
        var max = list.Max() + 1;

        var sum = sut.SumEven(below: max);
        Assert.Equal(sumTest, sum);
    }

    [Fact]
    [Trait("ProblemE002", "")]
    public void SolutionTest()
    {
        var result = sut.SumEven(below: 4000000);

        var hashedResult = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(result.ToString()));
        //System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(XX.ToString()))
        byte[] expectedBytes = { 179, 215, 132, 187, 175, 18, 134, 97, 42, 212, 67, 8, 35, 26, 165, 131, 80, 218, 23, 166 };

        Assert.Equal(expectedBytes, hashedResult);
    }

}