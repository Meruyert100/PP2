using System;

namespace Task1
{
    class MainClass
    {
        public static bool Prime(int num)//function which check for primes
        {
            if (num == 1) return false;//if number is 1 returns false
            for (int i = 2; i < num; i++)//use cycle to move through array
                if (num % i == 0)//make condition
                    return false;//if condition is false returns false
            return true;//if condition is true returns true
        }

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
            int cnt = 0;// create a variable of integer type
            for (int i = 0; i < n; i++)// pass through our array to find number of primes
            {
                if (Prime(numbers[i]))//check if number is prime with function
                {
                    cnt++;// if condition is true, we increment cnt
                }
            }
            Console.WriteLine(cnt);//output on a new line
            for (int i = 0; i < n; i++)//pass through our array to find primes
            {
                if (Prime(numbers[i]))//check if number is prime with function
                {
                    Console.Write(numbers[i] + " ");//if condition is true, output prime numbers
                }
            }
        }
    }
}