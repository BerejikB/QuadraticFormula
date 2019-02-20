using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sqrtOp = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(sqrtOp)) / (2 * a);
            double x2 = (-b - Math.Sqrt(sqrtOp)) / (2 * a);
            Console.WriteLine("Real Solutions" + x1 , x2);
            Console.ReadKey();

        }
    }
}
