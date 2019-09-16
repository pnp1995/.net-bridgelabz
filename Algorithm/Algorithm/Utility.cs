using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Utility
    {
        public string String_input()
        {
            Console.WriteLine("Enter the string");
            string s = Convert.ToString(Console.ReadLine());
            return s;
        }
        public void InsertString(String[] arr)
        {
            int n = arr.Length;
            string temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((arr[i].CompareTo(arr[j]) > 0))
                    {
                        temp = arr[i];
                        arr[j] = arr[i];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void InsertInteger(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public void BinaryInteger(int[] arr, int first, int last, int key)
        {
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (arr[mid] == key)
                {
                    Console.WriteLine(key + "is found at index: " + mid);
                    break;

                }
                else if (key > arr[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }

                mid = (first + last) / 2;
                if (first > last)
                {
                    Console.WriteLine("element is not found");
                }
            }
        }
        public void BinaryString(string[] arr, int first, int last, string key)
        {
            int mid = (first + last) / 2;
            while (first <= last)
            {
                int store = key.CompareTo(arr[mid]);
                if (store == 0)
                {
                    Console.WriteLine(key + "element is found at index" + (mid + 1));
                    break;
                }
                else if (store < 0)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
                mid = (first + last) / 2;
            }
            if (first > last)
            {
                Console.WriteLine("Element is not found");
            }
        }
        public int[] BubbleSort()
        {
            int[] arr = { 5, 2, 3, 2, 7, 88, 67 };
            int len = 6;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After bubble sort");


            return arr;
        }

        public string[] BubbleSortStr(string[] str, int len)
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (str[j].CompareTo(str[i]) < 0)
                    {
                        string temp = str[j];
                        str[j] = str[i];
                        str[i] = temp;
                    }
                }
            }
            return str;
        }
        public void Merge(string[] arr, int l, int m, int r)
        {
            ////Calculate length of two subarrays
            int n1 = m - l + 1;
            int n2 = r - m;
            string[] L = new string[n1];
            string[] R = new string[n2];
            ////move strings from left of mid in L subarray
            for (int i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            ////move strings from right of mid in R subarray
            for (int j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }
            ////Merge the temporary arrays
            int p = 0, n = 0;
            //// Initial index of merged sub array array
            int k = l;
            while (p < n1 && n < n2)
            {
                if (L[p].CompareTo(R[n]) < 0)
                {
                    arr[k] = L[p];
                    p++;
                }
                else
                {
                    arr[k] = R[n];
                    n++;
                }

                k++;
            }
            //// Copy remaining elements of L[] if any
            while (p < n1)
            {
                arr[k] = L[p];
                p++;
                k++;
            }
            ////Copy remaining elements of R[] if any */
            while (n < n2)
            {
                arr[k] = R[n];
                n++;
                k++;
            }
        }
        



        //public void PrintArray(string[] arr)
        //{
        //    int n = arr.Length;
        //    for (int i = 0; i < n; i++)
        //{ }

        //}
    }
}

