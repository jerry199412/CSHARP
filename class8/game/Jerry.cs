using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Jerry : Player, IGameMaker
    {
        public void Gamemaker()
        {
            Console.WriteLine("我也会做游戏");
        }
    }
}
