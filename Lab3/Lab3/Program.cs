using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Первый объект с заданными координатами и символом
            //Point p1 = new Point(2, 4, '*');
            //p1.Draw();

            //// Второй объект - копия первого через конструктор с параметром типа Point
            //Point p2 = new Point(3,2,'*');
            //p2.Draw();

            //// Проверка пересечения: вызываем IsHit у p1, передавая p2
            //bool hit = p1.IsHit(p2);
            //Console.SetCursorPosition(0, 6); // Позиционное смещение для вывода результата
            //Console.WriteLine("Пересечение точек: " + (hit ? "Да" : "Нет"));

            // Горизонтальная линия на y = 5, от x = 2 до x = 8
            HoriztalLine hLine = new HoriztalLine(2, 9, 5, '*');
            hLine.Draw();

            // Вертикальная линия на x = 5, от y = 3 до y = 7
            VerticalLine vLine = new VerticalLine(3, 8, 5, '*');
            vLine.Draw();

            // проверка пересечения линий
            bool isIntersect = hLine.IsHit(vLine);
            Console.WriteLine("Линии пересекаются: " + (isIntersect ? "Да" : "Нет"));


            Console.ReadKey();
        }
    }
}