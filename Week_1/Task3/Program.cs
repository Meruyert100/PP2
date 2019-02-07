using System;

namespace Task3
{
    class MainClass
    {
        public static void NewArray(int[] arr1, int[] arr2, int a, int x, int n, string[] str)//method for creating new array
        {
            for(int i = 0; i < n; i++)// since we have n numbers in the array, we cycle through it
            {
                arr1[i] = Convert.ToInt32(str[i]);//convert elements of array of strings to integer
            }
            for(int i = 0; i < n; i++)// since we have n numbers in the array, we cycle through it
            {
                for (int j = a; j < x; j++)// since we have x numbers in the array, we cycle through it
                {
                    arr2[j] = arr1[i];//2nd array's 2nd element equals to 1st arrays 1st element
                }
                a += 2;//adding 2 to increase array's location
            }
            for(int i = 0;i < x; i++)// since we have x numbers in the array, we cycle through it
            {
                Console.Write(arr2[i] + " ");//output elements of arr1 with space
            }
        }
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // size of array
            int[] arr1 = new int[n];//one dimensinal array with size n

            int x = n * 2;//multiply by 2 to get size of 2nd array
            int a = 0;//new integer

            int[] arr2 = new int[x];//one dimensional array with size x
            string s = Console.ReadLine();//saving entered string
            string[] str = s.Split();//divide the entered string by spaces and save to an array of string type

            NewArray(arr1, arr2, a, x, n, str);//calling function

        }
    }
}