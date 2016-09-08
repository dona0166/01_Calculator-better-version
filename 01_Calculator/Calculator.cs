using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
           return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int result = 0;
            foreach(int element in numbers)
            {
                result += element;
            }
            return result;
        }

        internal static int Multiply(int[] numbers)
        {
            int result = 1;
            for(int i = 0; i<numbers.Length; i++)
            {
                result *= numbers[i]; 
            }
            return result;
        }

        internal static int Power(int b, int e)
        {
            int[] numbers = new int[e];
            int result = 1;
            for(int i = 0; i < e; i++)
            {
                numbers[i] = b;
            }
            foreach(int element in numbers)
            {
                result *= element;
            }
            return result;
        }

        internal static int Factorial(int v)
        {
            int[] numbers;
            int result = 1;
            int increase = 1;
            if( v == 0)
            {
                return 1;
            }
            else
            {
                numbers = new int[v];
                for(int i = 0; i<v; i++)
                {
                    numbers[i] = increase;
                    increase++;
                }
                for(int y = 0; y<numbers.Length; y++)
                {
                    result *= numbers[y];
                }
                return result;
            }
        }
    }
}