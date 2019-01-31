using System;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // size of array
            string s = Console.ReadLine(); // saving entered string
            string[] ss = s.Split(' ');// divide the entered string by spaces and save to an array of string type
            int[] numbers = new int[n]; // we get a new array of integer type

            for (int i = 0; i < n; i++) // since we have n numbers in the array, we cycle through it
            {
                int number = Convert.ToInt32(ss[i]); // convert elements of array of strings to integer
                numbers[i] = number; // write the converted element in our array of integer type
            }

            for (int i = 0; i < n; i++) // since we have n numbers in the array, we cycle through it
            {
                Console.Write(numbers[i] + " " + numbers[i] + " ");//output
            }
        }
    }
}