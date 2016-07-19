using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPoint(1, 3,'*');
            DrawPoint(5, 4, '#');

            Console.ReadLine();
        }
        static void DrawPoint(int x, int y, char sym)
        {
            Point p = new Point(x,y,sym);
            p.Draw();
        }
    }
}
