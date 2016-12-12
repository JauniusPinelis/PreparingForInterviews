using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary.SimpleProblemSolvers
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below (non-inclusive) input.
    /// </summary>
    public class SimpleProblemSolver
    {
        public int Solve3And5Multiples(int maxNumber)
        {
            int sum = 0;
            for (int i = 1; i < maxNumber; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum;
        }
    }
}
