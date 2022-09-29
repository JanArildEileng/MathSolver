using MathSolver.Eulerproblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver.Mysolution.Olkv
{
    public class E001Multiplesof3and5 : IProblemE001
    {
        public int Sum(int below)
        {
            //Finner hvor mange tall som kan multipliseres med det minste grunntallet (3), til å bestemme antall loop iterasjoner
            int round = Convert.ToInt32(Math.Floor((below-1)/3.0));    
            int  mysum = 0;
            HashSet<int> hs = new HashSet<int>();

            for (int i = 1; i <= round; i++)
            {
                // Tar vare på "allerede sett" tall, slik at samme bidrag fra 5 grunntall ikke tas med for 3 grunntall (og vise versa)
                if (!hs.Contains((i * 3)))
                {
                    hs.Add((i * 3));
                    mysum = mysum + (i * 3);
                }
                if ((i*5) < below && !hs.Contains(( i * 5)))
                {
                    hs.Add((i * 5));
                    mysum = mysum + (i * 5);
                }
            }
            return mysum;
        }
    }
}
