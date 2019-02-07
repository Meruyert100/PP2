using System;
using System.IO;
namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*File.Create(@"c:/Users/meruyerttastandiyeva/Desktop/newfile.txt");

            string spath= @"c:/Users/meruyerttastandiyeva/Desktop/newfile.txt";
            string tpath = @"c:/Users/meruyerttastandiyeva/Documents";

            File.Copy(spath, tpath, true);

            try
            {
                File.Delete(@"c:/Users/meruyerttastandiyeva/Desktop/newfile.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }*/
            string pathstring = "c:/Users/meruyerttastandiyeva/Desktop";
            string targetstring = "/Users/meruyerttastandiyeva/Documents";
            string filename = "newfile.txt";
            pathstring = Path.Combine(pathstring, filename);

            File.Create(pathstring);
            targetstring = Path.Combine(targetstring, filename);

            File.Copy(pathstring, targetstring, true);

            try
            {
                File.Delete(@"c:/Users/meruyerttastandiyeva/Desktop/newfile.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
