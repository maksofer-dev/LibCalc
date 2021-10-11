using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibCalc.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Multi_2and5_10returned()
        {
            //arrange
            int x = 2;
            int y = 5;
            int expected = 10;

            //actual
            Calc c = new Calc();
            int actual = c.Multi(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
