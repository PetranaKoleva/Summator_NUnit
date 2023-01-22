using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2, 3 };
            var actual = Summator.Sum(nums);
            var expected = 6;

            Assert.That(actual, Is.EqualTo(expected)); 
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -98 };
            var actual = Summator.Sum(nums);
            var expected = -99;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 8 };
            var actual = Summator.Sum(nums);
            var expected = 8;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000001, 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);
            var expected = 8000000001;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Category("Average")]
        [Test]
        public void Test_Summator_AverageTwoNum()
        {
            var nums = new int[] { 2, 4 };
            var actual = Summator.Average(nums);
            var expected = 3;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AverageZeroNum()
        {
            var nums = new int[0];
            var actual = Summator.Average(nums);
            var expected = (double)double.NaN;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AverageBigNum()
        {
            var nums = new int[] { 12213123, 22345342, 12321312, 434222314 };
            var actual = Summator.Average(nums);
            var expected = Enumerable.Average(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AverageNegativeNum()
        {
            var nums = new int[] { -12213123, -22345342, -12321312, -434222314 };
            var actual = Summator.Average(nums);
            var expected = Enumerable.Average(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyTwoNum()
        {
            var nums = new int[] { 5, 6 };
            var actual = Summator.Multiply(nums);
            var expected = 1;
            foreach(int num in nums)
            {
                expected *= num;
            }

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyNegativeNums()
        {
            var nums = new int[] { -5, -6, -9, -10 };
            var actual = Summator.Multiply(nums);
            var expected = 1;
            foreach(int num in nums)
            {
                expected *= num;
            }

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyZeroNums()
        {
            var nums = new int[0];
            var actual = Summator.Multiply(nums);
            var expected = 1;
            foreach(int num in nums)
            {
                expected *= num;
            }

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}