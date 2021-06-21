using GenericProblems;
using NUnit.Framework;

namespace MaxTest1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //UC1_Integervalue
        //Testcase 1.1
        public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            MaximumNumber max = new MaximumNumber();
            int firstValue = 10, secondValue = 20, thirdValue = 30;
            int expected = 30;
            int actual = max.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //TestCase 1.2
        public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            MaximumNumber max = new MaximumNumber();
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            int actual = max.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //TestCase 1.3
        public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            MaximumNumber find = new MaximumNumber();
            int firstValue = 20, secondValue = 10, thirdValue = 30;
            int expected = 30;
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //End of test cases for int value

        [Test]
        //UC2-ForFloat value
        //TestCase 2.1
        public void Maximum_Float_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 30.5f, secondValue = 20.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            MaximumNumber find = new MaximumNumber();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //TestCase 2.2
        public void Maximum_float_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 20.5f, secondValue = 30.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            MaximumNumber find = new MaximumNumber();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //TestCase 2.3
        public void Maximum_Float_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 20.5f, secondValue = 10.5f, thirdValue = 30.5f;
            float expected = 30.5f;
            MaximumNumber find = new MaximumNumber();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //End of Testcases for float number

        [Test]
        //UC3-For string 
        //TestCase 3.1
        public void Maximum_String_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Tiger", secondValue = "Elephant", thirdValue = "Cow";
            string expected = "Tiger";
            MaximumNumber find = new MaximumNumber();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //TestCase 3.2
        public void Maximum_String_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Elephant", secondValue = "Tiger", thirdValue = "Cow";
            string expected = "Tiger";
            MaximumNumber find = new MaximumNumber();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //TestCase 3.3
        public void Maximum_String_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            //Arrange
            string firstValue = "Cow", secondValue = "Elephant", thirdValue = "Tiger";
            string expected = "Tiger";
            //Act
            MaximumNumber find = new MaximumNumber();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //End of Testcases for string

        [Test]
        //Refactor1 TestCases
        public void MaximumInt_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            //Act
            int result = MaximumNumber.MaxValue<int>(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MaximumFloat_ValueAt_SecondParameter_Return_Highest_value()
        {
            //Arrange
            float firstValue =30.5f, secondValue = 20.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            //Act
            float result = MaximumNumber.MaxValue<float>(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MaximumString_ValueAt_ThirdParameter_Return_Highest_value()
        {
            //Arrange
            string firstValue = "Tiger", secondValue = "Elephant", thirdValue = "Cow";
            string expected = "Tiger";
            //Act
            string result = MaximumNumber.MaxValue<string>(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
        //End of Refactor1
        [Test]
        //Refactor-2 Test cases
        public void MaxInt_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            //Act
            int result = GenericMaximum<int>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MaxFloat_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            float firstValue = 30.5f, secondValue = 20.5f, thirdValue = 10.5f;
            float expected = 30.50f;
            //Act
            float result = GenericMaximum<float>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MaxString_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            string firstValue = "Tiger", secondValue = "Elephant", thirdValue = "Cow";
            string expected = "Tiger";
            //Act
            string result = GenericMaximum<string>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        //UC4-Test case
        [Test]
        public void Passing_Integer_Array_Should_Return_Maximum_Value()
        {
            //Arrange
            int[] intArray = { 50, 70, 65, 90, 80 };
            int expected = 90;
            //Act
            FindMax<int> find = new FindMax<int>(intArray);
            int actual = find.FindMaxValue();
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        [Test]
        public void Passing_float_Array_Should_Return_Maximum_Value()
        {
            float[] floatArray = { 30.5f, 20.5f, 10.5f, 35.5f, 50.5f };
            float expected = 50.5f;
            FindMax<float> find = new FindMax<float>(floatArray);
            float actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Passing_double_Array_Should_Return_Maximum_Value()
        {
            double[] doubleArray = { 60.50, 30.56, 25.00, 65.95 };
            double expected = 65.95;
            FindMax<double> find = new FindMax<double>(doubleArray);
            double actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Passing_string_Array_Should_Return_Maximum_Value()
        {
            string[] strArray = { "Tiger", "Roar", "Cow", "Bark", "Dog" };
            string expected = "Tiger";
            FindMax<string> find = new FindMax<string>(strArray);
            string actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }


    }
}