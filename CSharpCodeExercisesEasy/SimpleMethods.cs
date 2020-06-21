using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace CSharpCodeExercisesEasy
{
    public class SimpleMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool ReturnTrue()
        {
            return true;
        }

        public static int Sum(int a = 0, int b = 0)
        {
            return a + b;
        }

        public static int ConvertMinutesToSeconds(int minutes = 0)
        {
            return minutes * 60;
        }

        public static int GetFirstElementInArray(int[] numbers)
        {
            return numbers[0];
        }

        public static bool IsStringEmpty(string str = "")
        {
            return str.Trim().Length == 0;
        }

        public static bool StringHasSpaces(string str = "")
        {
            return Regex.IsMatch(str, "\\s+");
        }

        public static bool StringHasSameCaseChars(string str = "")
        {
            bool hasUpper = str.Any(char.IsUpper);
            bool hasLower = str.Any(char.IsLower);
            return !(hasUpper && hasLower);
        }
    }
}
