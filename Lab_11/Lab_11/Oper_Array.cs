using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    class Oper_Array
    {
        public static int Max(int[] array, int length, int index)
        {
           
            if (index == length - 1) return array[index];
            
            int res = Max(array, length, index + 1);
            
            if (array[index] > res)
                return array[index];
            else
                return res;
        }



        public static int Min(int[] array, int length, int index)
        {
            
            if (index == length - 1) return array[index];

            
            int res = Min(array, length, index + 1);

            
            if (array[index] < res)
                return array[index];
            else
                return res;
        }


        public static void Fibonacci(int nr1, int nr2, int i, int nr)
        {
            Console.Write(nr1 + " ");
            if (i < nr)
            {
                Fibonacci(nr2, nr1 + nr2, i + 1, nr);
            }
        }

    }
}
