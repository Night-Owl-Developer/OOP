using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Верхняя горизонтальная линия (начало x = 0, конец x = 9, y = 0, знак '*')
            HoriztalLine h1 = new HoriztalLine(0, 9, 0, '*');
            h1.Draw();

            // Нижняя горизонтальная линия (начало x = 0, конец x = 9, y = 3, знак '*')
            HoriztalLine h2 = new HoriztalLine(0, 9, 3, '*');
            h2.Draw();

            // Левая вертикальная линия (начало y = 1, конец y = 3, x = 0, знак '*')
            VerticalLine v1 = new VerticalLine(1, 3, 0, '*');
            v1.Draw();

            // Правая вертикальная линия (начало y = 1, конец y = 3, x = 8, знак '*')
            VerticalLine v2 = new VerticalLine(1, 3, 8, '*');
            v2.Draw();

            Console.ReadKey();
        }
    }
}