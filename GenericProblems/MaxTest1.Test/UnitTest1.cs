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
        public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            MaximumNumber max = new MaximumNumber();
            int firstValue = 10, secondValue = 20, thirdValue = 30;
            int expected = 30;
            int actual = max.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            MaximumNumber max = new MaximumNumber();
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            int actual = max.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            MaximumNumber find = new MaximumNumber();
            int firstValue = 20, secondValue = 10, thirdValue = 30;
            int expected = 30;
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}