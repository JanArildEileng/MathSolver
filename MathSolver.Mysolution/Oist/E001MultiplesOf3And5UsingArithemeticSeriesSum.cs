using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Oist
{
    public class E001MultiplesOf3And5UsingArithemeticSeriesSum : IProblemE001
    {
        public int Sum(int below)
        {
            int numOf3Multiples = NumberOfSteps(below, 3);
            int numOf5Multiples = NumberOfSteps(below, 5);
            int numOf15Multiples = NumberOfSteps(below, 3*5);

            int sumOf3Multiples = SumOfArithmeticSeries(3, numOf3Multiples);
            int sumOf5Multiples = SumOfArithmeticSeries(5, numOf5Multiples);
            int sumOf15Multiples = SumOfArithmeticSeries(15, numOf15Multiples);

            return sumOf3Multiples + sumOf5Multiples - sumOf15Multiples;
        }

        private int NumberOfSteps(int below, int stepLength)
        {
            return (below - 1) / stepLength;
        }

        private int SumOfArithmeticSeries(int stepLength, int numOfSteps)
        {
            return stepLength * numOfSteps * (1 + numOfSteps) / 2;
        }

    }
}
