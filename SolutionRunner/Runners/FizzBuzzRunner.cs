﻿using MainClassLibrary.SimpleProblemSolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionRunner.Runners
{
    public class FizzBuzzRunner : Runner
    {
        SimpleProblemSolver solver;

        public FizzBuzzRunner()
        {
            solver = new SimpleProblemSolver();
        }

        public void Run()
        {
            List<string> results = solver.SolveFizzBuzz(100);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
