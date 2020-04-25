using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tall, int lenght, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tall);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
