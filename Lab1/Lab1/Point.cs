using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Lab1
{
    class Point
    {
        int x; 
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение Х не может быть отрицательным");
        }

        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение Y не может быть отрицательным");
        }

        public void SetSym(char symbol)
        {
            sym = symbol;
        }

        public void Draw(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
