using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort_AS_16
{
    internal class Program
    {
        
            public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    Console.WriteLine("The given array is not sorted");
            }
            Console.WriteLine("The array is  sorted");
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, -2, 6, 8, -6};
            Console.WriteLine("Original Array");
            Print(arr);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            QuickSort(arr);
            sw.Stop();
            Console.WriteLine("After Quick Sort");
            Print(arr);
            Console.WriteLine($"Array Size {arr.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(arr);
            Console.WriteLine();
            int[] arr1 = { 2, 3, 88, 44, 21, 90, 7, 87, 91, 100, 11, 23, 36, 6, 10, 13, 12, 9, 1, 22 };
            Console.WriteLine("Original Array 1");
            Print(arr1);
            sw.Start();
            QuickSort(arr1);
            sw.Stop();
            Console.WriteLine("After Quick Sort Array 1");
            Print(arr1);
            Console.WriteLine($"Array Size {arr1.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(arr1);
            Console.WriteLine();
            int[] arr2 = { 45, 12, 38, 27, 19, 50, 33, 8, 22, 14, 49, 3, 36, 17, 41, 7, 29, 5, 48, 11, 31, 20, 42, 9, 26, 15, 37, 2, 47, 23, 10, 32, 6, 44, 18, 30, 13, 34, 21, 46, 1, 39, 24, 4, 28, 16, 35, 25, 40, 43 };
            Console.WriteLine("Original Array 2");
            Print(arr2);
            sw.Start();
            QuickSort(arr2);
            sw.Stop();
            Console.WriteLine("After Quick Sort Array 2");
            Print(arr2);
            Console.WriteLine($"Array Size {arr2.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(arr2);
            Console.WriteLine();
            int[] arr3 = { 54, 87, 23, 69, 42, 10, 78, 33, 91, 16, 57, 29, 63, 5, 72, 49, 14, 37, 82, 25, 8, 44, 70, 12, 61, 3, 95, 20, 46, 68 };
            Console.WriteLine("Original Array 3");
            Print(arr3);
            sw.Start();
            QuickSort(arr3);
            sw.Stop();
            Console.WriteLine("After Quick Sort Array 3");
            Print(arr3);
            Console.WriteLine($"Array Size {arr3.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(arr3);
            Console.ReadKey();
        }
    }
}        
    
