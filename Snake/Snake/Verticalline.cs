using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Verticalline
    {
        List<Point> pList2;

        public Verticalline(int yFirst, int yDown, int x, char sym)
        {
            pList2 = new List<Point>();
            for(int y = yFirst; y <= yDown; y++ )
            {
                Point p = new Point(x, y, sym);
                pList2.Add(p);
            }
        }
        public void Drow()
        {
            foreach(Point p in pList2)
            {
                p.Draw();
            }
        }
    }
}
