using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality.Exceptions;

public static class Warning
{
    public static void Message(string warning)
    {
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine(warning);
        PressAnyKey();
        Console.ResetColor();
        Console.CursorVisible = true;
        Console.Clear();
    }
    public static void PressAnyKey()
    {
        Console.WriteLine("\n  Press Any Key To Go Back . . .");
        Console.ReadKey();
    }
}
