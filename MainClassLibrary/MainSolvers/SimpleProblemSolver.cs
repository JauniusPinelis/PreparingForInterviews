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
        public int Solve3And5Multiples(int limitNumber)
        {
            int sum = 0;
            for (int i = 1; i < limitNumber; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum;
        }

        /// <summary>
        /// Write a program that prints the numbers from 1 to 100. 
        /// But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
        /// For numbers which are multiples of both three and five print “FizzBuzz
        /// 
        /// I dont know how to test it with unit test
        /// </summary>
        public List<string> SolveFizzBuzz(int limitNumber)
        {
            var elements = new List<string>();

            for (int i = 0; i < limitNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    elements.Add("FizzBuzz");
                else if (i % 3 == 0)
                    elements.Add("Fizz");
                else if (i % 5 == 0)
                    elements.Add("Buzz");
                else
                    elements.Add(i.ToString());
            }

            return elements;

        }

        public int GetEvenFibonacciNumbers(int upperNumber)
        {
            return GetFibonacciNumbers().TakeWhile(x => x <= upperNumber)
                .Where((_, i) => i % 3 == 0).Sum();
        }

        public IEnumerable<int> GetFibonacciNumbers()
        {
            int first = 0;
            int second = 1;

            while (true)
            {
                var nextFibonacciNumber = first + second;
                yield return nextFibonacciNumber;

                first = second;
                second = nextFibonacciNumber;
            }
        }
    }
}
