using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

public class Point
{
    private string X, Y;
    public Point (string _X, string _Y){ X = _X; Y = _Y; }
    public void Show() { Console.WriteLine("X: " + X + " Y: " + Y); }      
}


    public class Tasks
{
    public Tasks() { }
    
} 

class Program
{
    public static void Task_1()
    {
        string str="",temp;
        do
        {
            temp = Console.ReadLine();
            if (temp.Length > 0) str+="X: " + temp.Substring(0,temp.IndexOf(",")) + "   \tY: " + temp.Substring(temp.IndexOf(",")+1)+"\n";
        }
        while (temp.Length != 0);
        Console.Write(str);
    }
    public static void Task_2()
    {
        try
        {
            StreamReader myStreamReader = new StreamReader(Console.OpenStandardInput());
            string temp;
            do
            {
                temp = myStreamReader.ReadLine();
                if (temp.Length > 0) Console.WriteLine("X: " + temp.Substring(0, temp.IndexOf(",")) + "   \tY: " + temp.Substring(temp.IndexOf(",") + 1));
            }
            while (temp.Length != 0);

            myStreamReader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
    /*public void Task_3()
    {
        TextBlock tb = new TextBlock("Hello World!");//создали новый элемент
        Thickness mrgn = new Thickness(0, 0, 0, 0);
        tb.Margin = mrgn;
        MasterGrid.Children.Add(tb);
    }*/
    static void Main(string[] args)
    {
        Console.WriteLine("----------Task 1----------");
        //Task_1();
        Console.WriteLine("----------Task 2----------");
        Task_2();
        Console.WriteLine("----------Task 3----------");

    }
}

