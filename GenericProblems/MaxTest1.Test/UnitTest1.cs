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

        [Test]
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
    }
}