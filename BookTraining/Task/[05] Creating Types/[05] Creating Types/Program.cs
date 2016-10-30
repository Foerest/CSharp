using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

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

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
    //void IUndoable.Undo() => Undo();
    public virtual void Undo() => Console.WriteLine("TextBox.Undo");
}
public class RichTextBox : TextBox, IUndoable
{
    public override void Undo() => Console.WriteLine("RichTextBox.Undo");
}


interface I { void Foo(); }
struct S : I
{
    public void Foo() { }
}

public enum BorderSide { Left, Right, Top, Bottom }

[Flags]
public enum BorderSides
{
    None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8
}

class test
{
    static void Main()
    {
        /*
        Console.WriteLine("Ready to sort one or more text lines...");

        // Start the Sort.exe process with redirected input.
        // Use the sort command to sort the input text.
        Process myProcess = new Process();

        myProcess.StartInfo.FileName = "Sort.exe";
        myProcess.StartInfo.UseShellExecute = false;
        myProcess.StartInfo.RedirectStandardInput = true;

        myProcess.Start();

        StreamWriter myStreamWriter = myProcess.StandardInput;

        // Prompt the user for input text lines to sort. 
        // Write each line to the StandardInput stream of
        // the sort command.
        String inputText;
        int numLines = 0;
        do
        {
            //Console.WriteLine("Enter a line of text (or press the Enter key to stop):");

            inputText = Console.ReadLine();
            if (inputText.Length > 0)
            {
                numLines++;
                myStreamWriter.WriteLine(inputText);
            }
        } while (inputText.Length != 0);*/


        // Write a report header to the console.
        if (numLines > 0)
        {
            Console.WriteLine(" {0} sorted text line(s) ", numLines);
            Console.WriteLine("------------------------");
        }
        else
        {
            Console.WriteLine(" No input was sorted");
        }

        // End the input stream to the sort command.
        // When the stream closes, the sort command
        // writes the sorted text lines to the 
        // console.
        myStreamWriter.Close();


        // Wait for the sort process to write the sorted text lines.
        myProcess.WaitForExit();
        myProcess.Close();
        */


        /*BorderSides leftRight = BorderSides.Left | BorderSides.Right;
        if ((leftRight & BorderSides.Left) != 0)
            Console.WriteLine("Includes Left");

        string formatted = leftRight.ToString(); // "Left, Right"
        BorderSides s = BorderSides.Left;
        s |= BorderSides.Right;
        Console.WriteLine(formatted);
        Console.WriteLine(s == leftRight); // True
        s ^= BorderSides.Right; // Toggles BorderSides.Right
        Console.WriteLine(s);

        int i = (int)BorderSide.Left;
        BorderSide side = (BorderSide)i;
        bool leftOrRight = (int)side <= 2;


        var foo = new Foo();
        //foo.X = 2;
        Console.WriteLine(foo.X);

        RichTextBox r = new RichTextBox();
        r.Undo(); // RichTextBox.Undo Case 1
        ((IUndoable)r).Undo(); // RichTextBox.Undo Case 2
        ((TextBox)r).Undo(); // TextBox.Undo Case 3

        var stock = new Stock();
        stock.CurrentPrice = 123.45M;
        Console.WriteLine(stock.CurrentPrice);
        var stock2 = new Stock { CurrentPrice = 83.12M };
        Console.WriteLine(stock2.CurrentPrice);*/

    }
}