using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainClassLibrary;
using MainClassLibrary.MainSolvers;

namespace PreparingForInterviews
{
    [TestClass]
    public class StringSolverTests
    {

        StringProblemSolver stringProblemSolver;

        public StringSolverTests()
        {
            stringProblemSolver = new StringProblemSolver();
        }

        [TestMethod]
        public void CheckIfCharsAreUnique()
        {
            Assert.AreEqual(stringProblemSolver.CheckIfAllCharsAreUnique("Abcd"), true);
        }

        [TestMethod]
        public void CheckIfCharsAreNotUnique()
        {
            Assert.AreEqual(stringProblemSolver.CheckIfAllCharsAreUnique("Testing"), true);
        }

        [TestMethod]
        public void CheckIfStringGetsReversed1()
        {
            Assert.AreEqual(stringProblemSolver.ReverseString("test"), "tset");
        }

        [TestMethod]
        public void CheckIfStringGetsReversed2()
        {
            Assert.AreEqual(stringProblemSolver.ReverseString("12"), "21");
        }

        [TestMethod]
        public void CheckIfDublicatesGetRemoved()
        {
            Assert.AreEqual(stringProblemSolver.RemoveDublicateCharacters("abcddd"), "abcd");
        }
    }
}
