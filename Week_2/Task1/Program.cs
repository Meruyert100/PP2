using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        static void Solve(string str)
        {
            bool ok = true;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[str.Length - 1 - i] != str[i])
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void Main(string[] args)
        {

            FileStream fs = new FileStream("/Users/meruyerttastandiyeva/Desktop/FileQ/hello.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();

            Solve(line);

            sr.Close();
            fs.Close();

        }
    }
}
