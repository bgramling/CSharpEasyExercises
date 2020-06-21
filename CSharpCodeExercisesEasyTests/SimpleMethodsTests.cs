using CSharpCodeExercisesEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpCodeExercisesEasyTests
{
    [TestClass]
    public class SimpleMethodsTests
    {
        [TestMethod]
        public void ReturnTrueTest()
        {
            bool result = SimpleMethods.ReturnTrue();
            Assert.IsTrue(result, "Should evaluate to true");
        }

        [TestMethod]
        public void SumTest()
        {
            int actual = SimpleMethods.Sum(2, 3);
            int expected = 5;
            Assert.AreEqual(expected, actual, 0, "Should sum to 5");

            actual = SimpleMethods.Sum(4);
            expected = 4;
            Assert.AreEqual(expected, actual, 0, "Should sum to 4");
        }

        [TestMethod]
        public void ConvertMinutesToSecondsTest()
        {
            int actual = SimpleMethods.ConvertMinutesToSeconds(5);
            int expected = 300;
            Assert.AreEqual(expected, actual, 0, "5 minutes should convert to 300 seconds");
        }

        [TestMethod]
        public void GetFirstElementInArrayTest()
        {
            int[] numbers = {80, 5, 100};
            int actual = SimpleMethods.GetFirstElementInArray(numbers);
            int expected = 80;
            Assert.AreEqual(expected, actual, 0, "80 Should be the first element in array");
        }
    }
}
