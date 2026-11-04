
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 3, 8, 4, 2 };

        for (int i = 0; i < arr.Length; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
