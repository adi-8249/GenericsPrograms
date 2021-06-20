using System;

namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic programs");
            MaximumNumber max = new MaximumNumber();
            Console.WriteLine(max.MaximumIntegerNumber(10,20,30));
        }
    }
}
