using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WeightCalculator;
namespace IdealWeightCalculatorTest
{
    [TestClass]
    public class IdealWeightCalculatorTest
    {
        [TestMethod]
        public void GetIdealWeight_Height_176_Gender_W_Return_63()
        {
            //Arrange
            IdealWeightCalculator idealWeightCalculatorForUnknown = new IdealWeightCalculator
            {
                Height = 176,
                Gender = 'w'
            };
            //Act
            double actual = idealWeightCalculatorForUnknown.GetIdealWeight();
            double expected = 63;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIdealWeight_Height_170_Gender_M_Return_65()
        {
            //Arrange
            IdealWeightCalculator idealWeightCalculatorForUnknown = new IdealWeightCalculator
            {
                Height = 170,
                Gender = 'm'
            };
            //Act
            double actual = idealWeightCalculatorForUnknown.GetIdealWeight();
            double expected = 65;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIdealWeight_Height_170_Gender_UnKnown_Return_0()
        {
            //Arrange
            IdealWeightCalculator idealWeightCalculatorForUnknown = new IdealWeightCalculator
            {
                Height = 170,
                Gender = 'f'
            };
            //Act
            double actual = idealWeightCalculatorForUnknown.GetIdealWeight();
            double expected = 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
