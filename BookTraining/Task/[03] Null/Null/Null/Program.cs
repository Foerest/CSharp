using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point { public int X, Y; }

class Test
{
    static void Main()
    {
        Point p = null;
        Console.WriteLine(p == null);
        //Console.WriteLine(p.X);    // exeption
        Point[] a = new Point[1000];
        //int x = a[500].X;   //exeption 
        //Point p = null;     // This line will not compile.
        //int x = null;		// Illegal, too.
    }
}