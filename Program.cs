using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 40, 57, 20, 9, 8 };
            int k;
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                k = i - 1;
                while (k >= 0 && array[k] > array[k + 1])
                {
                    temp = array[k];
                    array[k] = array[k + 1];
                    array[k + 1] = temp;
                    k = k - 1;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}