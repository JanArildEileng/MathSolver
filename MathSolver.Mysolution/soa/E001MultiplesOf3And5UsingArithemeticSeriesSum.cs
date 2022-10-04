using MathSolver.Eulerproblems;

// Dette er en kopi av Øistein sin algoritme. 
// Men fjernet kall til en metode og satt metode til static for å bruke mindre minne

namespace MathSolver.Mysolution.SOA
{
    public class E001MultiplesOf3And5UsingArithemeticSeriesSum : IProblemE001
    {
        public int Sum(int below)
        {
           
           var numOf3Multiples = SumOfArithmeticSeries(3, below);
           var numOf5Multiples = SumOfArithmeticSeries(5, below);
           var numOf15Multiples = SumOfArithmeticSeries(15, below);
           
            return numOf3Multiples + numOf5Multiples - numOf15Multiples;
        }
       
        static private int SumOfArithmeticSeries(int stepLength, int below)
        {
            var numOfSteps = (below - 1) / stepLength;
            return stepLength * numOfSteps * (1 + numOfSteps) / 2;
        }

    }
}
