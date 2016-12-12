using SolutionRunner.Runners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionRunner
{
    class Program
    {
        /// <summary>
        /// Not Everything can be easily automated with Unit tests
        /// Some algorithms will have to be run by console 
        /// and checked manually. Oh well..
        /// </summary>
        static void Main(string[] args)
        {
            FizzBuzzRunner runner = new FizzBuzzRunner();
            runner.Run();      
        }
    }
}
