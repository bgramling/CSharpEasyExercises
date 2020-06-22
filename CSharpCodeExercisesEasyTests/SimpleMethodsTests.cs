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

        [TestMethod]
        public void IsStringEmptyTest()
        {
            bool actual = SimpleMethods.IsStringEmpty("Test String");
            Assert.IsFalse(actual, "Test String is not an empty string");

            actual = SimpleMethods.IsStringEmpty("  ");
            Assert.IsTrue(actual, "Was an empty string");
        }

        [TestMethod]
        public void StringHasSpacesTest()
        {
            bool actual = SimpleMethods.StringHasSpaces("NoSpaces");
            Assert.IsFalse(actual, "String does not have spaces so should be false");

            actual = SimpleMethods.StringHasSpaces("Has Spaces");
            Assert.IsTrue(actual, "String does have spaces so should be true");
        }

        [TestMethod]
        public void StringHasSameCaseCharsTest()
        {
            bool actual = SimpleMethods.StringHasSameCaseChars("THIS IS ALL UPPERCASE");
            Assert.IsTrue(actual, "String contains all uppercase chars so should be true");

            actual = SimpleMethods.StringHasSameCaseChars("this is all lowercase");
            Assert.IsTrue(actual, "String contains all lowercase chars so should be true");

            actual = SimpleMethods.StringHasSameCaseChars("This has Mixed case Letters.");
            Assert.IsFalse(actual, "String contains a mixture of case so should be false");
        }

        [TestMethod]
        public void FindMinAndMaxInNumbersTest()
        {
            int[] numbers = { 2, 3, 56, 7, 1, 32 };
            int[] actual = SimpleMethods.FindMinAndMaxInNumbers(numbers);

            int expected = 1;
            Assert.AreEqual(expected, actual[0], 0, "The number 1 should be the smallest");

            expected = 56;
            Assert.AreEqual(expected, actual[1], 0, "The number 56 should be the largest");
        }
    }
}
