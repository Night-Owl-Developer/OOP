using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Lab2
{
    class Point
    {
        int x;
        int y;
        char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(sym);
        }
    }
}
