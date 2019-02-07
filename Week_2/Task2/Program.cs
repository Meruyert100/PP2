using System;
using System.IO;
using System.Linq;

namespace Task2
{
    class MainClass
    {
        public static bool Prime(int num)
        { 
            if (num == 1) return false;
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        static bool isNotFour(int n)
        {
            return n != 0;
        }

        public static void Main(string[] args)
        {
            string text = File.ReadAllText("/Users/meruyerttastandiyeva/Desktop/FileQ/hello.txt");

            string[] myarray = text.Split(' ');
            int n = myarray.Length;
            int[] numbers = new int[n];
            int[] primes = new int[n];
                     
            for(int i = 0; i < myarray.Length; i++)
            {
                int number = Convert.ToInt32(myarray[i]); 
                numbers[i] = number;
            }


            for (int i = 0; i < n; i++)
            {
                if (Prime(numbers[i]))
                {
                    primes[i] = numbers[i];
                }
            }
            
            primes = Array.FindAll(primes, isNotFour).ToArray();

            File.WriteAllText("/Users/meruyerttastandiyeva/Desktop/FileQ/bye.txt", string.Join(" ", primes));

        }
    }
}
