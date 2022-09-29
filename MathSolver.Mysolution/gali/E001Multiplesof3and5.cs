﻿using MathSolver.Eulerproblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver.Mysolution.gali
{
    public class E001Multiplesof3and5 : IProblemE001
    {
        //Find the sum of all the multiples of 3 or 5 below 1000.    

        // i*3 = j*5 => i=j*5/3, (i,j) => (5,3),(10,6),(15,9),..
        public int Sum(int below)
        {
            var sum3 = 0;
            var N = below / 3;
            N = (N*3 == below) ? N - 1 : N;
            for (int i = 1; i <= N; i++)
            {
                sum3 += i * 3;
            }

            var sum5 = 0;
            var M = below / 5;
            M = (M*5 == below) ? M - 1 : M;
            for (int j = 1; j <= M; j++)
            {
                var x = j * 5;
                if (x % 3 == 0) continue;
                sum5 += x;
            }

            var sum = sum3 + sum5;

            return sum;
        }
    }
}