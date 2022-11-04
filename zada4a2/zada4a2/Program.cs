using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, a, x, z, b, result;

            y = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            double sq = y + 6 * a - 2 / 3 * (x + 6);
            double sqr = Math.Pow(sq, 6);
            result = sqr - z / z + 7 * b;

            Console.WriteLine("Резултат= " + result);
            Console.WriteLine("Натиснете произволен клавиш. . .");

        }
    }
}
