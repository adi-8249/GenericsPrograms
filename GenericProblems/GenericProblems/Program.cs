using System;

namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic programs");
            MaximumNumber max = new MaximumNumber();
            //maximum for integer value
            Console.WriteLine(max.MaximumIntegerNumber(10,20,30));
            //Maximum for float value
            Console.WriteLine(max.MaximumFloatNumber(10.5f,20.5f,30.5f));
            //Maximum for string
            Console.WriteLine(max.MaximumStringNumber("Tiger","Elephant","Cow"));

            //Refactor1
            int maxint = MaximumNumber.MaxValue<int>(10, 20, 30);
            Console.WriteLine("Maximum Integer Value " + maxint);
            float maxfloat = MaximumNumber.MaxValue<float>(10.5f, 20.5f, 30.5f);
            Console.WriteLine("Maximum Float Value " + maxfloat);
            string maxstring = MaximumNumber.MaxValue<string>("Tiger", "Elephant", "Cow");
            Console.WriteLine("Maximum String Value " + maxstring);

            //Refactor2
            int genericForInt = GenericMaximum<int>.MaxValue(20, 40, 50);
            Console.WriteLine("Maximum Int Value: " + genericForInt);
            float genericForFloat = GenericMaximum<float>.MaxValue(10.5f, 20.5f, 30.5f);
            Console.WriteLine("Maximum Float Value: " + genericForFloat);
            string genericForString = GenericMaximum<string>.MaxValue("Tiger", "Elephant", "Cow");
            Console.WriteLine("Maximum String Value: " + genericForString);

            //UC4- Taking more parameters
            int[] intArray = { 50, 70, 65, 90, 80 };
            FindMax<int> find1 = new FindMax<int>(intArray);

            float[] floatArray = { 30.5f, 20.5f, 10.5f, 35.5f, 50.5f };
            FindMax<float> find2 = new FindMax<float>(floatArray);

            double[] doubleArray = { 60.50, 30.56, 25.00, 65.95 };
            FindMax<double> find3 = new FindMax<double>(doubleArray);

            string[] stringArray = { "Tiger", "Roar", "Cow", "Bark", "Dog" };
            FindMax<string> find4 = new FindMax<string>(stringArray);

            Console.WriteLine("Maximum Integer Value is: " + find1.FindMaxValue());
            Console.WriteLine("Maximun Float Value is: " + find2.FindMaxValue());
            Console.WriteLine("Maximun double Value is: " + find3.FindMaxValue());
            Console.WriteLine("Maximum String Value is: " + find4.FindMaxValue());
        }
    }
}
