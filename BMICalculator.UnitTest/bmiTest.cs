using BMICalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BMICalculator.UnitTest
{
    [TestClass]
    public class bmiTest
    {
        [TestMethod]
        public void TestBMIValue_Calculates_ReturnCalculation()
        {
            //Arrange
            BMI calcBMIValue = new BMI();
            calcBMIValue.WeightStones = 8;
            calcBMIValue.WeightPounds = 4;
            calcBMIValue.HeightFeet = 5;
            calcBMIValue.HeightInches = 7;

            double testTotalWeightInPounds = (calcBMIValue.WeightStones * 14) + calcBMIValue.WeightPounds;
            double testTotalHeightInInches = (calcBMIValue.HeightFeet * 12) + calcBMIValue.HeightInches;

            // do conversions to metric
            double testTotalWeightInKgs = testTotalWeightInPounds * 0.453592;
            double testHeightInMetres = testTotalHeightInInches * 0.0254;

            double expectedResult = testTotalWeightInKgs / (Math.Pow(testHeightInMetres, 2));

            //Act
            double actualResult = calcBMIValue.BMIValue;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnCategoryUnderweight()
        {
            //Arrange
            BMI calcBMIValue = new BMI();
            calcBMIValue.WeightStones = 5;
            calcBMIValue.WeightPounds = 4;
            calcBMIValue.HeightFeet = 5;
            calcBMIValue.HeightInches = 7;

            //double testBMIValue = calcBMIValue.BMIValue;

            BMICategory expectedResult = BMICategory.Underweight;

            //Act
            BMICategory actualResult = calcBMIValue.BMICategory;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnCategoryNormal()
        {
            //Arrange
            BMI calcBMIValue = new BMI();
            calcBMIValue.WeightStones = 10;
            calcBMIValue.WeightPounds = 4;
            calcBMIValue.HeightFeet = 5;
            calcBMIValue.HeightInches = 7;

            //double testBMIValue = calcBMIValue.BMIValue;

            BMICategory expectedResult = BMICategory.Normal;

            //Act
            BMICategory actualResult = calcBMIValue.BMICategory;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnCategoryOverweight()
        {
            //Arrange
            BMI calcBMIValue = new BMI();
            calcBMIValue.WeightStones = 12;
            calcBMIValue.WeightPounds = 4;
            calcBMIValue.HeightFeet = 5;
            calcBMIValue.HeightInches = 7;

            //double testBMIValue = calcBMIValue.BMIValue;

            BMICategory expectedResult = BMICategory.Overweight;

            //Act
            BMICategory actualResult = calcBMIValue.BMICategory;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestBMICategory_Calculates_ReturnCategoryObese()
        {
            //Arrange
            BMI calcBMIValue = new BMI();
            calcBMIValue.WeightStones = 50;
            calcBMIValue.WeightPounds = 4;
            calcBMIValue.HeightFeet = 5;
            calcBMIValue.HeightInches = 7;

            //double testBMIValue = calcBMIValue.BMIValue;

            BMICategory expectedResult = BMICategory.Obese;

            //Act
            BMICategory actualResult = calcBMIValue.BMICategory;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
