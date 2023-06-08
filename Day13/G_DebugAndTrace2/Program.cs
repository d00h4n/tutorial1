using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int x = 5, y = 7;

        // Use Debug to print a message to the Output window and pause the debugger
        Debug.WriteLine("Starting program...");
        Debug.WriteLine("x = " + x);
        Debug.WriteLine("y = " + y);
        Debug.WriteLine("");

        // Use Trace to print a message to the Output window without pausing the debugger
        Trace.WriteLine("Calculating x + y...");
        int sum = x + y;
        Trace.WriteLine("x + y = " + sum);
        Trace.WriteLine("");

        // Use Debug.Assert to check if a condition is true and pause the debugger if it's false
        Debug.Assert(sum == 12, "The sum of x and y should be 12");

        // Use Debug.Fail to output a message and pause the debugger unconditionally
   //     Debug.Fail("This point should never be reached.");

        // Use Debug.WriteLineIf to conditionally print a message to the Output window
        Debug.WriteLineIf(sum > 10, "The sum is greater than 10.");

        // Use Debug.Print to write a formatted string to the Output window
        Debug.Print("Sum: {0}", sum);

        // Use Debug.Write to write a message to the Output window
        Debug.Write("Press any key to continue...");

        // Use Debug.Flush to flush any pending debug output
        Debug.Flush();

        // Use Debugger.Break to break into the debugger at a specific point in code
        Debugger.Break();

        Console.ReadKey();
    }
}
