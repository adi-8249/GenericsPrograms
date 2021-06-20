using System;

namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic programs");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4 };
            char[] charArray = { 'H', 'E', 'F', 'P', 'S' };

            MaximumNumber.ToPrint(intArray);
            MaximumNumber.ToPrint(doubleArray);
            MaximumNumber.ToPrint(charArray);
        }
    }
}
