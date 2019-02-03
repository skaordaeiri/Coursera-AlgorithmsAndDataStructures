﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using A3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Tests
{
    [TestClass()]//Grade:A3:100
    public class ProgramTests
    {
        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_FibonacciTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessFibonacci, "TD1");
        }

        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_FibonacciLastDigitTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessFibonacci_LastDigit, "TD2");
        }

        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_GCDTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessGCD, "TD3");
        }

        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_LCMTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessLCM, "TD4");
        }

        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_FibonacciModTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessFibonacci_Mod, "TD5");
        }


        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_FibonacciSumTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessFibonacci_Sum, "TD6");
        }

        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_FibonacciPartialSumTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessFibonacci_Partial_Sum, "TD7");
        }

        [TestMethod()]
        [DeploymentItem("TestData", "A3_TestData")]
        public void Graded_FibonacciSumSquaresTest()
        {
            TestCommon.TestTools.RunLocalTest("A3", Program.ProcessFibonacci_Sum_Squares, "TD8");
        }

        [TestMethod()]
        public void GetPisanoTest()
        {
            Assert.IsTrue(Program.GetPisano(3) == 8);
            Assert.IsTrue(Program.GetPisano(123) == 40);
            Assert.IsTrue(Program.GetPisano(24476) == 42);
        }
    }
}