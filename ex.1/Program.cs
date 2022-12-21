using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte quantity = byte.Parse(Console.ReadLine());
            byte red = 0;
            byte orange = 0;
            byte blue = 0;
            byte green = 0;
            string max = null;
            byte maxValue = 0;

            for (int i = 1; i <= quantity; i++)
            {
                string colour = Console.ReadLine();
                switch (colour)
                {
                    case "red":
                        red++;
                        break;
                    case "orange":
                        orange++;
                        break;
                    case "blue":
                        blue++;
                        break;
                    case "green":
                        green++;
                        break;

                }
            }
            if (red > orange && red > blue && red > green)
            {
                max = "red";
                maxValue = red;
            } else if (orange > red && orange > blue && orange > green)
            {
                max = "orange";
                maxValue = orange;
            } else if (blue > red && blue > orange && blue > green)
            {
                max = "blue";
                maxValue = blue;
            } else if (green > red && green > blue && green > orange)
            {
                max = "green";
                maxValue = green;
            }

            Console.WriteLine("Red eggs: {0}", red);
            Console.WriteLine("Orange eggs: {0}", orange);
            Console.WriteLine("Blue eggs: {0}", blue);
            Console.WriteLine("Green eggs: {0}", green);
            Console.WriteLine("Max eggs: {0} -> {1}", maxValue, max);
            Console.ReadKey();
        }
    }
}
