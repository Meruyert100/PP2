using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        static void Solve(string str)// create a method
        {
            bool ok = true;
            for (int i = 0; i < str.Length; ++i)// pass through array
            {
                if (str[str.Length - 1 - i] != str[i])//checking for polindrome
                {
                    ok = false;
                    break;//if it is not a polindrome we exit from cycle
                }
            }

            if (ok)// if it is a polindrome, we output "Yes"
            {
                Console.WriteLine("Yes");
            }
            else// if it is not a polindrome, we output "No"
            {
                Console.WriteLine("No");
            }
        }
        public static void Main(string[] args)
        {

            FileStream fs = new FileStream("/Users/meruyerttastandiyeva/Desktop/FileQ/hello.txt", FileMode.Open, FileAccess.Read);//open file to read from it

            StreamReader sr = new StreamReader(fs);//create a stream reader and link it to the file stream

            string line = sr.ReadLine();//create a string varible, where we save a string from file

            Solve(line);//calling a method

            sr.Close();// closing a stream
            fs.Close();// closing a stream
            //Without closing a stream, nothing will be written to the file

        }
    }
}