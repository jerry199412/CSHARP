﻿using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IGameMaker gameMaker = new Jerry();
            gameMaker.Gamemaker();
        }
    }
}
