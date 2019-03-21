﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static bool gameover = false;
        static void Main(string[] args)
        {
            GameState gameState = new GameState();
            gameState.ShowBanner();
            gameState.GetInput();

            while (!gameover)
            {
                gameState.Draw();
                gameState.CheckWall();
                gameState.UpdateLevel();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.PressedKey(consoleKeyInfo);

            }
        }
    }
}