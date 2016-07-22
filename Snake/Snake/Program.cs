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
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine line = new HorizontalLine(0, 78, 0, '#');
            line.Drow();

            Verticalline Vline = new Verticalline(0, 23, 0, '#');
            Vline.Drow();

            Verticalline VlineR = new Verticalline(0, 23, 78, '#');
            VlineR.Drow();

            HorizontalLine lineD = new HorizontalLine(0, 78, 24, '#');
            lineD.Drow();

            
        }
    }
}
