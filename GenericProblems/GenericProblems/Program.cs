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
            Console.WriteLine(max.MaximumFloatNumber(10.5f,20.5f,30.5f));
            Console.WriteLine(max.MaximumStringNumber("Tiger","Elephant","Cow"));
        }
    }
}
