using System;
using System.Collections.Generic;
using System.Text;

namespace Inserstion_sort
{
    internal class insertionsort
    {
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Shift elements greater than key one position to the right
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 9, 4, 7, 1, 8, 2 };

            Console.WriteLine("Before: " + string.Join(", ", numbers));

            InsertionSort(numbers);

            Console.WriteLine("After:  " + string.Join(", ", numbers));

            Console.ReadKey();
        }
    }
}