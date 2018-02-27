using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EEMMain;

namespace UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest_Util
    {
        public UnitTest_Util()
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


        //[TestMethod]
        //[DeploymentItem("|ProjectName|\\TestData\\Util_GetNextFolder.xml")]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        //           "|DataDirectory|\\Util_GetNextFolder.xml",
        //           "FolderTest",
        //            DataAccessMethod.Sequential)]
        //public void TestMethod_GetNextFolderDDT()
        //{
        //    string target = (string)this.TestContext.DataRow["Expected"];
        //    string inputFolder = (string)this.TestContext.DataRow["Input"]; ;
        //    string actual = string.Empty;
        //    actual = Util.GetNextFolder(inputFolder);
        //    Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
        //    Assert.IsTrue(target == actual);
        //}


        [TestMethod]
        public void TestMethod_GetNextFolder()
        {
            string target = "F00";
            string inputFolder = "F";
            string actual = string.Empty;
            actual = Util.GetNextFolder(inputFolder);
            Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
            Assert.IsTrue(target == actual);
        }

        [TestMethod]
        public void TestMethod_GetNextFolder01()
        {
            string target = "Sample00";
            string inputFolder = "Sample";
            string actual = string.Empty;
            actual = Util.GetNextFolder(inputFolder);
            Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
            Assert.IsTrue(target == actual);
        }

        [TestMethod]
        public void TestMethod_GetNextFolder02()
        {
            string target = "Sample04";
            string inputFolder = "Sample03";
            string actual = string.Empty;
            actual = Util.GetNextFolder(inputFolder);
            Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
            Assert.IsTrue(target == actual);
        }

        [TestMethod]
        public void TestMethod_GetNextFolder03()
        {
            string target = "S04";
            string inputFolder = "S03";
            string actual = string.Empty;
            actual = Util.GetNextFolder(inputFolder);
            Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
            Assert.IsTrue(target == actual);
        }

        [TestMethod]
        public void TestMethod_GetNextFolder04()
        {
            string target = "xyz00";
            string inputFolder = "xyz";
            string actual = string.Empty;
            actual = Util.GetNextFolder(inputFolder);
            Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
            Assert.IsTrue(target == actual);
        }

        [TestMethod]
        public void TestMethod_GetNextFolder05()
        {
            string target = "xyz01";
            string inputFolder = "xyz00";
            string actual = string.Empty;
            actual = Util.GetNextFolder(inputFolder);
            Console.WriteLine("Input:{0}  Target:{1}  Actual:{2}", inputFolder, target, actual);
            Assert.IsTrue(target == actual);
        }


    }
}
