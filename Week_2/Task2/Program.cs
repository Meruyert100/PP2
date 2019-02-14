using System;
using System.IO;
using System.Linq;

namespace Task2
{
    class MainClass
    {
        public static bool Prime(int num)//function which checks for primes
        {
            if (num == 1) return false;//if number is 1 returns false
            for (int i = 2; i < num; i++)//use cycle to move through array
                if (num % i == 0)//make condition
                    return false;//if condition is false returns false
            return true;//if condition is true returns true
        }
        static bool isNotZero(int n)//function which removes zeros
        {
            return n != 0;//returns all numbers except zeros
        }

        public static void Main(string[] args)
        {
            string text = File.ReadAllText("/Users/meruyerttastandiyeva/Desktop/FileQ/hello.txt");//read the file as one string

            string[] myarray = text.Split(' ');//divide the entered string by spaces and save to an array of string type
            int n = myarray.Length;//length of an array
            int[] numbers = new int[n];//create new array
            int[] primes = new int[n];//create new array

            for (int i = 0; i < myarray.Length; i++)//we pass through array
            {
                int number = Convert.ToInt32(myarray[i]);//convert elements of array of strings to integer
                numbers[i] = number;//write the converted element in our array of integer type
            }


            for (int i = 0; i < n; i++)//use cycle to move through array
            {
                if (Prime(numbers[i]))//check if number is prime with function
                {
                    primes[i] = numbers[i];//write the prime number in array of primes
                }
            }

            primes = Array.FindAll(primes, isNotZero).ToArray();//retrieve all the elements that match the conditions defined by the specified function

            File.WriteAllText("/Users/meruyerttastandiyeva/Desktop/FileQ/bye.txt", string.Join(" ", primes));//WriteAllText creates a file, writes the specified string to the file, and then closes the file

        }
    }
}
