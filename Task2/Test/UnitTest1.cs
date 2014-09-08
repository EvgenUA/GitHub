using System;
using Dispersion;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            var _array =  new int []{1,2,5,4,10,20};
            var calc = new Calculator(_array);
            var res = calc.CalMethod();
            var act = new Tuple<int, int>(3,15);
            Assert.AreEqual(res,act);
           
        }
    }
}
