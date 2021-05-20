// @ Author:Aya Kurtam
using System;

namespace DDA_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int dx, dy, m, xStart, yStart, xEnd, yEnd;

            // To read Start point
            Console.WriteLine("Please write the Start point");
            string xStart_string, yStart_string;
            Console.WriteLine("X1:");
            xStart_string = Console.ReadLine();
            xStart = Convert.ToInt32(xStart_string);
            Console.WriteLine("Y1:");
            yStart_string = Console.ReadLine();
            yStart = Convert.ToInt32(yStart_string);

            // To read End point
            Console.WriteLine("Please write the End point");
            string xEnd_string, yEnd_string;
            Console.Write("X2:");
            xEnd_string = Console.ReadLine();
            xEnd = Convert.ToInt32(xEnd_string);
            Console.Write("Y2:");
            yEnd_string = Console.ReadLine();
            yEnd = Convert.ToInt32(yEnd_string);

            dx = xEnd - xStart; // x2-x1
            dy = yEnd - yStart; // y2-y1

            m = Math.Max(Math.Abs(dx), Math.Abs(dy)); // Slope

            float xInc, yInc, x, y;
            x = xStart;
            y = yStart;

            xInc = (float)dx / (float)m;
            yInc = (float)dy / (float)m;

            Console.WriteLine("x=" + x + "\t" + "y=" + y);
            for(int i=0; i<m; i++)
            {
                x += xInc;
                y += yInc;
                Console.WriteLine("x=" + x + "\t" + "y=" + y);
            }
        }
    }
}
