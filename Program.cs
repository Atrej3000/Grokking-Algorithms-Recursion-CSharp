using System;
using System.Linq.Expressions;

namespace DivideAndConquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Sum(2, 4, 6)}");
            Console.WriteLine($"{Count(2, 4, 6, 5, 9, 12)}");
            Console.WriteLine($"{Max(2, 4, 6, 10, 8)}");
        }
        static int Sum(params int[] array)
        {
            if (array.Length == 1)
            {
                return array.First();
            }
            return array.First() + Sum(array.Skip(1).ToArray());
        }
        static int Count(params int[] array)
        {
            if (array.Length == 1)
            {
                return 1;
            }
            return 1 + Count(array.Skip(1).ToArray());
        }
        static int Max(params int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }
            return Math.Max(array[0], Max(array.Skip(1).ToArray()));
        }
    }
}