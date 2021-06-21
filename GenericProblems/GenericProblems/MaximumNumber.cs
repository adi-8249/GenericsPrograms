using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProblems
{
    public class MaximumNumber
    {
        //UC1-maximum number for integer value
        public int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
        //UC2-maximum number for float value
        public float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
        //UC3-Maximum for string value
        public string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
            {
                return thirdString;
            }
            return firstString;
        }
        //Refactor1
        //Refactoring all into one generic method
        public static T MaxValue<T>(T firstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0)
            {
                return firstValue;
            }
            if (Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0)
            {
                return secondValue;
            }
            if (Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0 ||
          Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0 ||
          Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0)
            {
                return thirdValue;
            }
            return default;
        }
    }
    //Refactor-2
    //creating generic class and taking three generic value 
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstValue; T secondValue; T thirdValue;
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;

        }
        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0)
            {
                return firstValue;
            }
            if (Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0 ||
           Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0)
            {
                return secondValue;
            }
            if (Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0 ||
          Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0 ||
          Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0)
            {
                return thirdValue;
            }
            return default;
        }

    }
    //UC4-Extending max to take more three parameters
    public class FindMax<dataType> where dataType : IComparable
    {
        public dataType[] array;
        public FindMax(dataType[] array)
        {
            this.array = array;
        }
        public dataType[] Sort(dataType[] values)
        {
            Array.Sort(values);
            return values;
        }
        public dataType FindMaxValue()
        {
            dataType[] sortedArray = Sort(this.array);
            return sortedArray[sortedArray.Length - 1];
        }
    }
}
    

