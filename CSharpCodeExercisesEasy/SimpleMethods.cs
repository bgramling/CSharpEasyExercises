using System;
using System.Net.NetworkInformation;

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
    }
}
