using System;
using System.IO;
namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pathstring = "/Users/meruyerttastandiyeva/Desktop";
            string targetstring = "/Users/meruyerttastandiyeva/Documents";
            string filename = "newfile.txt";
            pathstring = Path.Combine(pathstring, filename);

            File.Create(pathstring);
            targetstring = Path.Combine(targetstring, filename);

            File.Copy(pathstring, targetstring, true);

            try
            {
                File.Delete("/Users/meruyerttastandiyeva/Desktop/newfile.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
