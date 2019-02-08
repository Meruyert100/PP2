using System;
using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        ShowAllFoldersUnder("/Users/meruyerttastandiyeva/Documents", 0);
    }
    private static void ShowAllFoldersUnder(string path, int indent)
    {
        try
        {
            foreach (string folder in Directory.GetDirectories(path))
            {
                Console.WriteLine("{0}{1}", new string(' ', indent), Path.GetFileName(folder));
                ShowAllFoldersUnder(folder, indent + 2);
            }
        }
        catch (UnauthorizedAccessException) { }
    }

}