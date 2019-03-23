using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;

namespace Snake
{
    public class GameState
    {
        System.Timers.Timer timer = new System.Timers.Timer(120);
        const int height = 20;
        const int width = 40;
        public Worm worm = new Worm('O');
        public Food food = new Food('@');
        public Wall wall = new Wall('#');
        string name;
        int score = 5;
        int degree = 1;
        string file = "/Users/meruyerttastandiyeva/Desktop/FileQ/hello.txt";
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        public void Run()
        {
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            food.GenerateLocation(worm.body, wall.body);
            wall.Draw();
            food.Draw();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            worm.Clear();
            worm.Move();
            worm.Draw();
            CheckCollision();
        }

        public void Stop()
        {
            timer.Stop();
            Console.Clear();
        }

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
                    else if (j == 0 || j == width - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('#');
                    }

                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(41, 0);
            Console.WriteLine("Username: " + name);
            Console.SetCursorPosition(41, 1);
            Console.WriteLine("Your score: " + score);
            Console.SetCursorPosition(41, 2);
            Console.WriteLine("Level: " + degree);

        }
        public void CheckFood()
        {
            if (worm.IsIntersected(food.body))
            {
                score++;
                if (score == 2)
                {
                    degree++;
                }
                if (score == 5)
                {
                    degree++;
                }
                worm.Eat(food.body);
                food.GenerateLocation(worm.body, wall.body);
                food.Draw();
            }

        }
        public void ProcessKeyEvent(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Dx = 0;
                    worm.Dy = -1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.Dx = 0;
                    worm.Dy = 1;
                    break;
                case ConsoleKey.RightArrow:
                    worm.Dx = 1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Dx = -1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.Spacebar:
                    timer.Enabled = !timer.Enabled;
                    break;
                case ConsoleKey.N:
                    string number = score.ToString();
                    string all = name + " " + number + " " + DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString();
                    Console.SetCursorPosition(0, 23);
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(33, 23);
                    Console.WriteLine("GAME OVER");
                    File.WriteAllText(file, all);
                    Environment.Exit(0);
                    break;

            }

        }


        private void CheckCollision()
        {
            if (worm.IsIntersected(wall.body) || worm.CheckWall())
            {
                timer.Enabled = false;
                Console.Clear();
                Console.SetCursorPosition(15, 20);
                Console.Write("Game over!");

            }
            else if (worm.IsIntersected(food.body))
            {
                score++;
                Console.SetCursorPosition(41, 1);
                Console.WriteLine("Your score: " + score);
                worm.Eat(food.body);
                Thread.Sleep(200 - score);
                food.GenerateLocation(worm.body, wall.body);
                food.Draw();
            }
        }


    }
}