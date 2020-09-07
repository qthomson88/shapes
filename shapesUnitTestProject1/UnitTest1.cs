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

        //ideally I would want to test the area and perimeter for both a triangle and rectangle with no inputs
        //these tests would of course be in separate methods
        //I would further want to test with inputs
        //thinking through this, I realize, it would probably be good to make getters and setters for all
        //the parameters so I could more easily test different inputs and outputs
        //that's not to say I couldn't still have the display be the way I made it, I would just want to
        //consider changing or adding some functions
    }
}
