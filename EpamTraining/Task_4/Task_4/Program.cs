using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    double x;
    double y;
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { y = value; }
    }
}

class Line
{
    Point firstpoint, secondpoint;
    public Line(Point A,Point B)
    {
        firstpoint = A;
        secondpoint = B;
    }
    public Point A
    {
        get { return firstpoint; }
    }
    public Point B
    {
        get { return secondpoint; }
    }
    public uint Length
    {
        get { return (uint)Math.Sqrt(Math.Pow(Math.Abs(firstpoint.X - secondpoint.X), 2) + Math.Pow(Math.Abs(firstpoint.Y - secondpoint.Y), 2)); }
    }
}

class Triangle
{
    Point A, B, C;
    public Triangle(params double[] Arr)
    {
        try
        {
            if (Arr.Length != 6) throw(new Exception("incorrect input"));
            A = new Point(Arr[0], Arr[1]);
            B = new Point(Arr[2], Arr[3]);
            C = new Point(Arr[4], Arr[5]);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public Triangle(params Point[] Arr)
    {
        try
        {
            if (Arr.Length != 3) throw (new Exception("incorrect input"));
            A = Arr[0];
            B = Arr[1];
            C = Arr[2];
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public double Perimeter
    {
        get
        {
            Line a = new Line(A, B), b = new Line(B, C), c = new Line(A, C);
            return (a.Length + c.Length + b.Length);
        }
    }
    public double Area
    {
        get
        {
            Line a = new Line(A, B), b = new Line(B, C), c = new Line(A, C);
            double p = Perimeter / 2;
            return Math.Sqrt(p*(p-a.Length)*(p - b.Length)*(p - c.Length));
        }
    }
}

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle ABC = new Triangle(0,0,0,3,4,0);
            Console.WriteLine("Perimeter: " + ABC.Perimeter);
            Console.WriteLine("Area: " + ABC.Area);
        }
    }
}
