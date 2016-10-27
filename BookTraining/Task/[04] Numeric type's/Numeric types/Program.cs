using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //int x = 127;
        //long y = 0x7F;

        //Real literals can use decimal and/or exponential notation. For example:
        //double d = 1.5;
        //double million = 1E06;

        // Numeric literal type inference:
        Console.WriteLine(1.0.GetType());  // Double  (double)
        Console.WriteLine(1E06.GetType());  // Double  (double)
        Console.WriteLine(1.GetType());  // Int32   (int)
        Console.WriteLine(0xF0000000.GetType());  // UInt32  (uint)
        Console.WriteLine(0x100000000.GetType());  // Int64   (long)

        // Numeric literals can be suffixed with a character to indicate their type:
        //   F = float
        //   D = double
        //   M = decimal
        //   U = uint
        //   L = long
        //   UL = ulong

        float fl = 0.15F;
        double dl1 = 0.15, dl2 = 0.15d;
        Console.WriteLine(fl.ToString() + " " + dl1.ToString() + " " + dl2.ToString());
        Console.WriteLine(fl == dl1);
        Console.WriteLine(fl == dl2);
        Console.WriteLine(dl1 == dl2);

        decimal dc1 = 0.15M;
        Console.WriteLine(dc1);
        int a = 2 / 3;      // 0
        // Division by zero is an error:
        //int c = 5 / a;      // throws DivisionByZeroException
        int c = 5;
        double dbl = 0, res1=dl1/a, res2=c/dbl;

        {
            float tenth = 0.1f;                       // Not quite 0.1
            float one = 1f;
            Console.WriteLine(one - tenth * 10f);    // -1.490116E-08
        }
        {
            decimal tenth = 0.1m;                     // Exactly 0.1
            decimal one = 1m;
            Console.WriteLine(one - tenth * 10m);    // 0.0
        }

        // Neither double nor decimal can precisely represent a fractional number whose base 10 representation is recurring:
        decimal m = 1M / 6M;               // 0.1666666666666666666666666667M
        double d = 1.0 / 6.0;             // 0.16666666666666666

        //m.Dump("m"); d.Dump("d");

        // This leads to accumulated rounding errors:
        decimal notQuiteWholeM = m + m + m + m + m + m;  // 1.0000000000000000000000000002M
        double notQuiteWholeD = d + d + d + d + d + d;  // 0.99999999999999989

        // which breaks equality and comparison operations:
        Console.WriteLine(notQuiteWholeM == 1M);   // False
        Console.WriteLine(notQuiteWholeD < 1.0);   // True
    }
}
