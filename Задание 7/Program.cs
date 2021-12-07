using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Инженер! \n введите длины в милиметрах");
            Console.WriteLine("Введите X");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Z");
            double Z = Convert.ToDouble(Console.ReadLine());
            AreaTriangle(X, Y, Z);
            Console.ReadKey();
        }

        static void AreaTriangle(double X, double Y, double Z)
        {
            double p = (double)((X + Y + Z) / 2);
            double S = Math.Sqrt(p * (p - X) * (p - Y) * (p - Z));
            Console.WriteLine("Площадь треугольника S = {0} кв. мм", S);
        }
    }
}
