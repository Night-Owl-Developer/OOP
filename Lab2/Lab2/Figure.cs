using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList) 
            {
                p.Draw();
            }
        }
    }

    // Наследники класса Figure

    class VerticalLine : Figure 
    {
        public VerticalLine(int yUp, int yDown, int x, char sym) 
        { 
            pList = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            { 
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

    class HoriztalLine : Figure
    {
        public HoriztalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
