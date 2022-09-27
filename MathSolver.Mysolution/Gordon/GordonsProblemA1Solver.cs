using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Gordon
{
    public class GordonsProblemA1Solver : IProblemA1
    {
        public int Sum(int a, int b)
        {
            var aListeOf1 = Enumerable.Repeat<int>(1, a).ToList();
            aListeOf1.AddRange(Enumerable.Repeat<int>(1, b).ToList());
            return aListeOf1.Sum();
        }
    }
}
