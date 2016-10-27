using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

public class Point
{
    private string X, Y;
    public Point (string _X, string _Y){ X = _X; Y = _Y; }
    public void Show() { Console.WriteLine("X: " + X + " Y: " + Y); }      
}


    public class Tasks
{
    public Tasks() { }
    public void Task_1()
    {
        string str = "", temp;
        do
        {
            temp = Console.ReadLine();
            str += temp + ',';
            if (temp.Length == 0 && str.Length > 1) str = str.Substring(0, str.Length - 2);
        }
        while (temp.Length > 0);

        string[] Arr = str.Split(',');

        for (int i = 0; i < Arr.Length; i += 2)
            Console.WriteLine("X: " + Arr[i] + " Y: " + Arr[i + 1]);
    }
    public void Task_2(string put="D:\\Test1.txt", string output="D:\\Test1!.txt")
    {
        String line;

        try
        {
            StreamReader sr = new StreamReader(put ?? "D:\\Test1.txt");
            StreamWriter sw = new StreamWriter(output ?? "D:\\Test1!.txt", true, Encoding.ASCII);

            line = sr.ReadLine();

            while (line != null)
            {
                string[] Values = line.Split(',');
                sw.WriteLine("X: " + Values[0] + " Y: " + Values[1]);
                line = sr.ReadLine();
            }

            sr.Close();
            sw.Close();
            Console.Read();
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
} 

class Program
{
    static void Main(string[] args)
    {
        Tasks a = new Tasks();
        Console.WriteLine("----------Task 1----------");
        a.Task_1();
        Console.WriteLine("----------Task 2----------");
        a.Task_2();
        Console.WriteLine("----------Task 3----------");

    }
}

