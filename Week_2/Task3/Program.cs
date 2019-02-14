using System;
using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        ShowAllFoldersUnder("/Users/meruyerttastandiyeva/Desktop", 0);//call a method
    }
    private static void ShowAllFoldersUnder(string path, int index)//create a method
    {

        foreach (string folder in Directory.GetDirectories(path))//loops through these folders, first displaying the name, then calling itself, passing the folder name, to look one level deeper
        {
            Console.WriteLine("{0}{1}", new string(' ', index), Path.GetFileName(folder));
            ShowAllFoldersUnder(folder, index + 2);
        }
    }
}