using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }
        static string NewtonMethodSqrtN(double n, double A, bool compare=false, double eps = 0.0001)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
            var x2 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
                if (!compare) continue;
                x0 = x2;
                x2 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
            }
            if(compare) return x1.ToString() + "  " + x2.ToString();
            return x1.ToString();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Task 1----------------");
            Console.WriteLine(NewtonMethodSqrtN(2,1024));
            Console.WriteLine("---------------Task 2----------------");
            Console.WriteLine(NewtonMethodSqrtN(2, 1024, true));
            Console.WriteLine(Math.Sqrt(1024));
        }
    }
}
