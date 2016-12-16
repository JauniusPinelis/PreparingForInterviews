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
            Assert.AreEqual(233168, simpleProblemSolver.Solve3And5Multiples(1000));
        }

        [TestMethod]
        public void CheckFibonacciNumberReturnsCorrect()
        {
            Assert.AreEqual(4613732, simpleProblemSolver.GetEvenFibonacciNumbers(4000000));
        }
    }
}
