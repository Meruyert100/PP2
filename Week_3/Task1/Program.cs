using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    class Layer//create a class
    {
        int selectedItemIndex;//create a integer variable
        public FileSystemInfo[] Items
        {
            get;
            set;
        }

        public int SelectedItemIndex
        {
            get//receiving a value
            {
                return selectedItemIndex;
            }
            set//chaging the value
            {
                if (value >= Items.Length)
                {
                    selectedItemIndex = 0;
                }
                else if (value < 0)
                {
                    selectedItemIndex = Items.Length - 1;
                }
                else
                {
                    selectedItemIndex = value;
                }
            }
        }

        public Layer(FileSystemInfo[] items)//create a constructor 
        {
            selectedItemIndex = 0;
            this.Items = items;
        }
        public void Draw()//create a method for manipulating with colors
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Items.Length; ++i)
            {
                if (i == selectedItemIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (Items[i].GetType() == typeof(DirectoryInfo))//if it is a file, its color will be yellow
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(i + 1 + "." + Items[i].Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("/Users/meruyerttastandiyeva/Documents");//make a reference to a directory


            Stack<Layer> history = new Stack<Layer>();//create a stack using the constructor

            history.Push(new Layer(dirInfo.GetFileSystemInfos()));//insert an element at the top of the stack

            bool quit = false;//create a bool variable
            while (!quit)//use while loop for executing a statements while a specified boolean expression is true
            {
                history.Peek().Draw();//returns the object at the top of the stack without removing it
                ConsoleKeyInfo pressedKey = Console.ReadKey();//create a variable that identifies the console key that was pressed
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    history.Peek().SelectedItemIndex--;//incrementing index
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    history.Peek().SelectedItemIndex++;//decrementing index
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    int x = history.Peek().SelectedItemIndex;
                    DirectoryInfo y = history.Peek().Items[x] as DirectoryInfo;//make a reference to a new directory
                    history.Push(new Layer(y.GetFileSystemInfos()));//insert an element at the top of the stack
                }
                else if (pressedKey.Key == ConsoleKey.Backspace)
                {
                    history.Pop();//removes and returns the object at the top of the stack
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    quit = true;//continue our cycle
                }
            }
        }
    }
}