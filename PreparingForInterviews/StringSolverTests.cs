using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainClassLibrary;

namespace PreparingForInterviews
{
    [TestClass]
    public class StringSolverTests
    {

        AllUniqueCharSolver allUniqueCharSolver;

        public StringSolverTests()
        {
            allUniqueCharSolver = new AllUniqueCharSolver();
        }

        [TestMethod]
        public void CheckIfCharsAreUnique()
        {
            Assert.AreEqual(allUniqueCharSolver.Solve("Abcd"), true);
        }

        [TestMethod]
        public void CheckIfCharsAreNotUnique()
        {
            Assert.AreEqual(allUniqueCharSolver.Solve("Testing"), true);
        }



        
    }
}
