﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharp101.Basics;

namespace SeeSharp101.tests.Basics
{
    /// <summary>
    /// Summary description for GraphTests
    /// </summary>
    [TestClass]
    public class GraphTests
    {
        public GraphTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Should_Return_Correct_Identity()
        {
            var graph = new Graph("Master Graph", new int[3,3]);
            Assert.AreEqual(graph.Name, "Master Graph");
            Assert.AreEqual(graph.Description, "One Graph to Rule Them All");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Argument_Exception_For_Invalid_Adjacency_Matrix()
        {
            var graph = new Graph("Master Graph", new int[1, 3]);
        }

        [TestMethod]
        public void Should_Report_Graph_Is_Connected()
        {
            var graph = new Graph("Master Graph", new int[3, 3] { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } });
            var graph2 = new Graph("Master Graph", new int[5, 5] { { 0, 1, 1, 0, 0 }, { 1, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 1, 0, 0, }, { 0, 0, 1, 0, 0 } });
            Assert.AreEqual(graph.IsConnected, true);
            Assert.AreEqual(graph2.IsConnected, true);

        }

        [TestMethod]
        public void Should_Report_Graph_Is_Not_Connected()
        {
            var graph = new Graph("Master Graph", new int[3, 3] { { 0, 1, 0 }, { 1, 0, 0 }, { 0, 0, 0 } });
            var graph2 = new Graph("Master Graph", new int[5, 5] { { 0, 1, 0, 0, 0 }, { 1, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 1, 0, 0, }, { 0, 0, 1, 0, 0 } } );
            Assert.AreEqual(graph.IsConnected, false);
            Assert.AreEqual(graph2.IsConnected, false);
        }
    }
}
