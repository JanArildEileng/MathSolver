using MathSolver.Eulerproblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver.Mysolution.tgje
{
    public class E001Multiplesof3and5 : IProblemE001
    {
        public int Sum(int below)
        {
            int total = 0;

            for (int iCnt3=3; iCnt3 < below; iCnt3=iCnt3+3)
            {
                total += iCnt3;
            }

            for (int iCnt5=5; iCnt5 < below; iCnt5=iCnt5+((iCnt5)%15))
            {
                total += iCnt5;
            }
            
            return total;

            /*return Enumerable.
              .Range(1, count: below - 1)
              .Where(i => ((i % 3 == 0 || i % 5 == 0)))
              .Sum();*/
        }
    }
}
