﻿using MathSolver.Eulerproblems;

namespace MathSolver.Mysolution.Jaei
{
    public class E001Multiplesof3and5 : IProblemE001
    {
        public int Sum(int below)
        {
            return Enumerable
              .Range(1, count: below - 1)
              .Where(i => (i % 3 == 0) || (i % 5) == 0)
              .Sum();
        }
    }
}
