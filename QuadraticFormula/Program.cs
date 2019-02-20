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
            Console.WriteLine("a = ?");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ?");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c = ?");
            double c = double.Parse(Console.ReadLine());
            double sqrtOp = (b * b) - 4 * a * c;

            if (sqrtOp < 0)
            {   Console.WriteLine("No solution");
                Console.ReadKey();
            }
                    
            else
              {

                double x1;
                double x2;
                x1 = ((-1) * b + Math.Sqrt(sqrtOp)) / (2 * a);
                x2 = ((-1) * b - Math.Sqrt(sqrtOp)) / (2 * a);
                Console.WriteLine("Real Solutions:" +   x1, x2);
                Console.ReadKey();
              }

        }
    }
}
