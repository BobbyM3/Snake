using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int yup, int ydown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yup; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }

        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
