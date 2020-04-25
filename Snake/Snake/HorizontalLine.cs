﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xleft; x<= xright; x++)
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
