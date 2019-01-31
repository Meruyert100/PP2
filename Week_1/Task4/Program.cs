using System;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//size of array
            for (int i = 0; i <= n; i++)//we pass through rows of array
            {
                for (int j = 0; j < i; j++)//we pass through columns of array
                {
                    Console.Write("[*] ");//output "[*]"
                }
                Console.WriteLine();//new line
            }
        }
    }
}