﻿using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Interactive block = new GameObjects(10, 10);
            block.interact();
        }
    }
}
