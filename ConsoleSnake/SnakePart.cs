﻿
namespace ConsoleSnake
{
    public class SnakePart
    {
        public int X { get; set; }
        public int Y { get; set; }

        public SnakePart()
        {
            X = 0;
            Y = 0;
        }

        public SnakePart(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
