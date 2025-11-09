using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первая папа символов "( )"
            Point p1 = new Point();
            p1.SetX(1);
            p1.SetY(1);
            p1.SetSym('(');
            p1.Draw(1,1);

            Point p2 = new Point();
            p2.SetX(2);
            p2.SetY(1);
            p2.SetSym(')');
            p2.Draw(2,1);

            // Вторая папа символов "( )"
            Point p3 = new Point();
            p3.SetX(4);
            p3.SetY(1);
            p3.SetSym('(');
            p3.Draw(4,1);

            Point p4 = new Point();
            p4.SetX(5);
            p4.SetY(1);
            p4.SetSym(')');
            p4.Draw(5,1);

            // Второрй ряд символов "/\"
            Point p5 = new Point();
            p5.SetX(2);
            p5.SetY(2);
            p5.SetSym('/');
            p5.Draw(2,2);

            Point p6 = new Point();
            p6.SetX(4);
            p6.SetY(2);
            p6.SetSym('\\');
            p6.Draw(4,2);

            Console.SetCursorPosition(0, 4);
            Console.ReadKey();
        }
    }
}