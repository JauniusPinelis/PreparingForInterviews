using MainClassLibrary.SimpleProblemSolvers;
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

            for (int i = 1; i < 100; i++)
                Log("Result for " + i + " is " + results[i]);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
