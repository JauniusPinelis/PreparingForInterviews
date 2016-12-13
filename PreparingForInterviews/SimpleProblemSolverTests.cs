using MainClassLibrary.SimpleProblemSolvers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingForInterviews
{
    [TestClass]
    public class SimpleProblemSolverTests
    {
        SimpleProblemSolver simpleProblemSolver;

        public SimpleProblemSolverTests()
        {
            simpleProblemSolver = new SimpleProblemSolver();
        }

        [TestMethod]
        public void CheckIf3And5ReturnsCorrect()
        {
            Assert.AreEqual(simpleProblemSolver.Solve3And5Multiples(1000), 233168);
        }

        [TestMethod]
        public void CheckFibonacciNumberReturnsCorrect()
        {
            Assert.AreEqual(simpleProblemSolver.GetEvenFibonacciNumbers(4000000), 4613732);
        }
    }
}
