using System;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndPrintAndMaxAndMinVector();

            Fibonacci();

        }
        private static void ReadAndPrintAndMaxAndMinVector()
        {
            int[] array = For_Console.ReadArrayFromConsole("Array");

            For_Console.PrintArray("Array", array);

            int max = Oper_Array.Max(array, array.Length, 0);
            Console.WriteLine($"Max Element of the array is  : " + max);

            int min = Oper_Array.Min(array, array.Length, 0);
            Console.WriteLine($"Min Element of the array is  : " + min);
            Console.WriteLine();
        }

        private static void Fibonacci()
        {
            int nr = For_Console.ReadNumber($"Number for Fibonacci  =", 3, 0);
            Oper_Array.Fibonacci(0, 1, 1, nr);
            Console.WriteLine();
        }
    }
}
