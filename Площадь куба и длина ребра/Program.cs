using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Площадь_куба_и_длина_ребра
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Инженер! \n введите длину ребра куба в милиметрах");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;
            cubeVolar(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба S = {0} кв. мм", S);
            Console.WriteLine("Объем куба S = {0} кв. мм", V);
            Console.ReadKey();
        }

        static void cubeVolar(double a, out double S, out double V)
        {
            S = Math.Pow(a, 2) * 6;
            V = Math.Pow(a , 3);
        }
    }
}
