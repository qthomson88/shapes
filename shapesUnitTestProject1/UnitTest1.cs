using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using shapes;

namespace shapesUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void area_with_no_inputs_should_be_0()
        {
            shape testShape = new shape();
            testShape.display();

            Assert.AreEqual(0, testShape.getArea());
        }

        [TestMethod]
        public void perimeter_with_no_inputs_should_be_0()
        {
            shape testShape = new shape();
            testShape.display();

            Assert.AreEqual(0, testShape.getPerimeter());
        }
    }
}
