using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateJenkins.Tests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Comment added 
            Assert.IsTrue(true);
            string obj1 = "Yo!";
            object obj2 = "Man";
            Assert.AreNotSame(obj1, actual: obj2);
            
            //adding this in trying something branch
            Assert.IsTrue(true);
            //end trying something branch

            //This is on more branch
        }
    }
}
