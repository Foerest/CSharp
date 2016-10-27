using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stock
{
    decimal currentPrice;
    public decimal CurrentPrice    
    {
        get { return currentPrice; }
        set { currentPrice = value; }
    }
}

public class Foo
{
    private decimal x;
    public decimal X
    {
        get { return x; }
        private set { x = Math.Round(value, 2); }
    }
}

class test
{
    static void Main()
    {
        var foo = new Foo();
        //foo.X = 2;
        Console.WriteLine(foo.X);
        
        var stock = new Stock();
        stock.CurrentPrice = 123.45M;
        Console.WriteLine(stock.CurrentPrice);
        var stock2 = new Stock { CurrentPrice = 83.12M };
        Console.WriteLine(stock2.CurrentPrice);
    }
}