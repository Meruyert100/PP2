using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Snake
{
    class GameState
    {
        static bool gameover = false;
        Worm w = new Worm('O');
        Food f = new Food('@');
        Wall b = new Wall('#');
        Wall2 b2 = new Wall2('#');
        Wall3 b3 = new Wall3('#');
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        const int height = 20;
        const int width = 79;
        string name;
        int score = 0;
        int degree = 1;
        string file = "/Users/meruyerttastandiyeva/Desktop/FileQ/hello.txt";
        public GameState()
        {
            Console.CursorVisible = false;
        }
        public void ShowBanner()
        {
            Console.SetWindowSize(width, height + 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            Console.WriteLine("||----------------------------------------------------------------------------||");
            Console.WriteLine("||----------------------------Welcome to Snake Game---------------------------||");
            Console.WriteLine("||----------------------------------------------------------------------------||");
            Console.WriteLine("                              Press any key to play                             ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                              Press Space to quit                               ");
            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            if (keypress.Key == ConsoleKey.Spacebar)
            {
                Environment.Exit(0);
            }
        }
        public void GetInput()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }
        public void Draw()
        {
             Console.Clear();
             Console.SetCursorPosition(0, 0);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0 || i == height - 1)
                        {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                        }
                        else if (j == 0 || j==width-1)
                        {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                        }

                }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Username: " + name);
                Console.WriteLine("Your score: " + score);
                Console.WriteLine("Level: " + degree);

            w.Draw();
            f.Draw();
            b.Draw();
        }
        public void Draw2()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                    }
                    else if (j == 0 || j == width - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                    }

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Username: " + name);
            Console.WriteLine("Your score: " + score);
            Console.WriteLine("Level: " + degree);

            w.Draw();
            f.Draw();
            b2.Draw();
        }
        public void Draw3()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                    }
                    else if (j == 0 || j == width - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                    }

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Username: " + name);
            Console.WriteLine("Your score: " + score);
            Console.WriteLine("Level: " + degree);

            w.Draw();
            f.Draw();
            b3.Draw();
        }
        void CheckFood()
        {
            if (w.CheckCollision(f.body[0]))
            {
                score++;
                if (score == 2 )
                {
                    degree++;
                }
                if (score == 5)
                {
                    degree++;
                }
                w.Eat(f.body[0]);
                f.Generate();
            }

        }
        public void UpdateLevel()
        {
            if (score >= 2 && score<5)
            {
                Console.Clear();
                Draw2();
            }
            if (score >= 5 && score <=7)
            {
                Console.Clear();
                Draw3();
            }
            if (score == 7)
            {
                Console.SetCursorPosition(33, 23);
                Console.WriteLine("YOU WIN!!!");
                Environment.Exit(0);
            }
        }
        public void CheckWall()
        {
            if (w.CheckWall())
            {
                gameover = true;
                Console.SetCursorPosition(33, 23);
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
               
            
        }

        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:

                        w.Move(0, -1);

                    break;
                case ConsoleKey.DownArrow:

                        w.Move(0, 1);

                    break;
                case ConsoleKey.LeftArrow:

                        w.Move(-1, 0);

                    break;
                case ConsoleKey.RightArrow:

                        w.Move(1, 0);

                    break;
                case ConsoleKey.Spacebar:
                    string number = score.ToString();
                    string all = name + " " + number + " "+ DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString();
                    Console.SetCursorPosition(0, 23);
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(33, 23);
                    Console.WriteLine("GAME OVER");
                    File.WriteAllText(file, all);
                    Environment.Exit(0);
                    break;
            }

            CheckFood();
        }

    }
}