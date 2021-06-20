using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProblems
{
    public class MaximumNumber
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------");
        }
        public static void ToPrint(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------");
        }
        public static void ToPrint(char[] inputArray)
        {
            foreach(char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------");
        }
    }
}
