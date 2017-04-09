namespace NUnit.Tests
{
    using System;
    using NUnit.Framework;
    using SoftwareTest;

    [TestFixture]
    public class NumberCalculatorTest
    {
        [Test]
        public void FindMaxAllPositiveNumberArr()
        {
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            int result = 0;
            result = nc.FindMax(numbers);
            Assert.That(result, Is.EqualTo(5));
        }
      
        [Test]
        public void FindMaxNULLException()
        {
            int[] testInt = new int[0];
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            Assert.That(() => nc.FindMax(testInt),
                        Throws.TypeOf<ArgumentException>());
            // If maxLength is smaller than zero, an ArgumentException is raised.
        }
        [Test]
        public void FindMaxWithNegNumbers()
        {
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            int[] numbers = new int[5] { -1, -2, -3, -4, -5 };
            int result = 0;
            result = nc.FindMax(numbers);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void FindnNumberofMax()
        {
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            int[] result = new int[3];
            int[] nresult = new int[3] { 5, 4, 3 };
            result = nc.FindMax(numbers, 3);
            Assert.That( result, Is.EqualTo(nresult));
        }
        [Test]
        public void FindnNumberofMaxNULLException()
        {
            int[] numbers = new int[0];
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            Assert.That(() => nc.FindMax(numbers, 3),
                        Throws.TypeOf<ArgumentException>());
            // If maxLength is smaller than zero, an ArgumentException is raised.
        }
        [Test]
        public void FindnNumberofMaxWherenisNegative()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5};
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            Assert.That(() => nc.FindMax(numbers, -1),
                        Throws.TypeOf<ArgumentException>());
            // If maxLength is smaller than zero, an ArgumentException is raised.
        }
        [Test]
        public void Sort()
        {
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            int[] numbers = new int[5] { 10, 34, 54, 12, 17 };
            int[] result = new int[5];
            int[] sortedArray = new int[5] { 10, 12, 17, 34, 54 };
            result = nc.Sort(numbers);
            Assert.That(result, Is.EqualTo(sortedArray));
        }
        [Test]
        public void SortWithEmptyArray()
        {
            int[] numbers = new int[0];
            SoftwareTest.NumberCalculator nc = new NumberCalculator();
            Assert.That(() => nc.FindMax(numbers),
                        Throws.TypeOf<ArgumentException>());
            // If maxLength is smaller than zero, an ArgumentException is raised.
        }
    }
}