using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EuclideanGCD
{
    uint[] numbers;
    uint GCDofNumbers;
    public EuclideanGCD(params uint[] Arr)
    {
        numbers = Arr;
        uint[] temp = new uint[Arr.Length];
        uint i=0;
        foreach (uint d in Arr)
            temp[i++] = d;
        GCDofNumbers = gcd(temp);
    }
    public uint GCD
    {
        get { return GCDofNumbers; }
    }
    public void Show()
    {
        Console.Write("GCD[ ");
        foreach (var number in numbers)
            Console.Write(number + " ");
        Console.Write("] = " + GCDofNumbers + "\n");
    }
    public uint gcd(uint[] Arr)
    {
        try
        {
            if (Arr.Length == 1) return Arr[0];
            int N = Arr.Length % 2 == 0 ? Arr.Length / 2 : Arr.Length / 2 + 1;
            uint[] NewArr = new uint[N];
            for (int i = 0, j = 0; i < Arr.Length-1; i += 2, j++)
            {
                while (Arr[i + 1] != 0)
                    Arr[i + 1] = Arr[i] % (Arr[i] = Arr[i + 1]);
                NewArr[j] = Arr[i];
            }
            if(Arr.Length % 2 != 0) NewArr[NewArr.Length - 1] = Arr[Arr.Length - 1];
            return gcd(NewArr);
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        return 0;
    }
    public uint Binary_gcd(uint u, uint v)
    {
        if (u == v)
        {
            GCDofNumbers = u;
            return 0;
        }
        if (u == 0)
        {
            GCDofNumbers = v;
            return 0;
        }
        if (v == 0)
        {
            GCDofNumbers = u;
            return 0;
        }
        if ((~u & 1) == ~u) 
        {
            if ((v & 1)==v)
                return Binary_gcd(u >> 1, v);
            else
                return Binary_gcd(u >> 1, v >> 1) << 1;
        }

        if ((~v & 1)==~v)
            return Binary_gcd(u, v >> 1);
        if (u > v)
            return Binary_gcd((u - v) >> 1, v);
        return Binary_gcd((v - u) >> 1, u);
    }
}

namespace _3_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            EuclideanGCD first = new EuclideanGCD(2, 5);
            first.Show();
            first.Binary_gcd(2,5);
            Console.WriteLine(first.GCD);
            first = new EuclideanGCD(10, 20, 30, 40);
            Console.WriteLine(first.GCD);
            first = new EuclideanGCD(18, 30);
            Console.WriteLine(first.GCD);
            first = new EuclideanGCD(30, 18, 54, 36, 48);
            Console.WriteLine(first.GCD);
        }
    }
}
