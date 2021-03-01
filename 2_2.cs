using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
           double y = 0, x = -6, b = 3, dx = 0.75;
            Console.WriteLine("\t  X\t\t\t Y\n");
            while (x <= b)
            {
                y=Math.Pow(x,4) - 12 * x + Math.Exp(x);
                Console.WriteLine("\t|"+x+"\t\t\t" + Math.Round(y,2)+"\t|");
                x += dx;
            }
        }
    }
}
