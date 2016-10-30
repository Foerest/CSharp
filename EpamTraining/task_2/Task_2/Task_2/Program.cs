using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitSet
{
    private string value;
    public string Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public BitSet() { }
    public BitSet(uint value)
    {
        this.IntToBitString(value);
    }
    private static uint LengthString(uint value)
    {
        uint N = 1;
        while (value > 1)
        {
            value /= 2;
            N++;
        }
        return N;
    }
    public void IntToBitString(uint value)
    {
        uint N = LengthString(value);
        uint tempnumber = (uint)Math.Pow((double)2, (double)N - 1);
        string result = "";
        for (int i = 0; i < N; i++)
        {
            result += ((tempnumber & value) == tempnumber ? "1" : "0");
            tempnumber >>= 1;
        }
        this.value = result;
    }
    public void Show()
    {
        Console.WriteLine(this.value);
    }
}

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BitSet bit=new BitSet(5);
            Console.WriteLine(bit.Value);
            bit.IntToBitString(7);
            bit.Show();
            bit.IntToBitString(15);
            Console.WriteLine(bit.Value);
        }
    }
}
