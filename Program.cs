using System;

namespace Evaluation
{
    internal class Program
    {
        static void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr[j], arr[j + 1]);
                    }
                }

            }
           
        }

        static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(i + " ");
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
            int[] array = { 5, 2, 6, 9, 4, 7, 8, 1, 3 };

            Console.WriteLine("Sorting..... ");
            sort(array);
            print(array);
            
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||");


            Console.WriteLine("Searching....... ");
            Console.WriteLine("Please enter a number to search:");
            int a = int.Parse(Console.ReadLine());
            int b = search(array, a);
            if (b != -1)
            {
                Console.WriteLine(a + " is exist in " + b + " index");
            }
            else
            {
                Console.WriteLine(a + " is not exist in this array");
                
            }
        }
    }
}