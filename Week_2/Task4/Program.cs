using System;
using System.IO;
namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pathstring = "/Users/meruyerttastandiyeva/Desktop";//specify a path, where we want to create a file
            string targetstring = "/Users/meruyerttastandiyeva/Documents";//specify a path, where we want to copy a file
            string filename = "newfile.txt";//create a file name
            pathstring = Path.Combine(pathstring, filename);//create a string that specifies the path to the file

            File.Create(pathstring);//creating the file
            targetstring = Path.Combine(targetstring, filename);//create a string that specifies the path to the file

            File.Copy(pathstring, targetstring, true);//copy a file to another location

            try//we use a try block to catch IOExceptions, to handle the case of the file already being opened by another process
            {
                File.Delete("/Users/meruyerttastandiyeva/Desktop/newfile.txt");//delete a file by using File class static method
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}

