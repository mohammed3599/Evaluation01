using System;

namespace Evaluation
{
    internal class Program
    {
        static void sort(int[] arr)
        {
            int a = arr.Length;
            for (int i = 0; i < a - 1; i++) 
            {
                for (int j = 0; j < a - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
           
        }

        static int search(int[] arr, int s)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {

                if (s == arr[i])
                {
                    return i;
                }

            }

            return -1;

        }
        static void Main(string[] args)
        {
            int[] array = { 5, 23, 61, 94, 46, 79, 84, 12, 37 };

            Console.WriteLine("Sorting..... ");
            sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||");


            Console.WriteLine("Searching....... ");
            Console.WriteLine("Please enter a number to search:");
            int a = int.Parse(Console.ReadLine());
            int b = search(array, a);
            if (b != -1)
            {
                Console.WriteLine(a + " is exist in  index " + b );
            }
            else
            {
                Console.WriteLine(a + " is not exist in this array");
                
            }
        }
    }
}