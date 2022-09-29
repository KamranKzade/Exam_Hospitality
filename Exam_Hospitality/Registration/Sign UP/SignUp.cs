using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;
using Exam_Hospitality.DataBase;
using Exam_Hospitality.Exceptions;
using Exam_Hospitality.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_Hospitality;

public class SignUP
{
    private static bool ValidInfos(string name, string surname, string age, string email, string username, string password, string city, string phoneNumber)
    {
        StackFrame callStack = new StackFrame(1, true);
        string currentFile = new StackTrace(true).GetFrame(0)!.GetFileName()!;
        // Check null or empty
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(age)
         || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(city)
         || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
        {
            Warning.Message("ALL INFORMATIONS WERE NOT ENTERED!");
            throw new DetailedException("All Informations Were Not Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile);
        }

        // Check username
        if (UsernameWasTaken(username))
        {
            Warning.Message("USERNAME WAS TAKEN!");
            throw new DetailedException("Username Was Taken!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        // Check Age
        if (IsValidAge(age) == -1)
        {
            Warning.Message("INCORRECT AGE WAS ENTERED!");
            throw new DetailedException("Incorrect Age Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }



        return true;
    }

    private static bool UsernameWasTaken(string username)
    {
        if (GlobalData.database.Admins != null)
        {
            foreach (Admin admin in GlobalData.database.Admins)
            {
                if (admin.UserName == username)
                {
                    return true;
                }
            }
        }

        return false;
    }
    private static int IsValidAge(string age)
    {
        int intAge;
        bool converted = int.TryParse(age, out intAge);
        if (converted)
        {
            if (intAge >= 0)
            {
                return intAge;
            }
        }
        return -1;
    }

    public static Admin SignUp()
    {
        Console.CursorVisible = true;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR NAME : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string name = Console.ReadLine()!.Trim();


        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR SURNAME : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string surname = Console.ReadLine()!.Trim();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR AGE : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string age = Console.ReadLine()!.Trim();


        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR USERNAME : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string username = Console.ReadLine()!.Trim();


        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR PASSWORD : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string password = Console.ReadLine()!.Trim();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR CITY : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string city = Console.ReadLine()!.Trim();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n ENTER YOUR Email : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string email = Console.ReadLine()!.Trim();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@" PHONE NUMBER EXAMPLES : 
    111 222 3344
    1234567890
    +1234567890
    +123-456-7890
    123-456-7890
    123-456-27890");

        Console.Write("\n ENTER YOUR PHONE NUMBER : ");
        Console.ForegroundColor = ConsoleColor.Green;
        string phone = Console.ReadLine()!.Trim();

        Console.CursorVisible = false;

        if (ValidInfos(name, surname, age, email, username, password, city, phone))
        {
            byte.TryParse(age, out byte age2);
        //    JsonSerialization.SerializeDatabase(GlobalData.database);
            return new Admin(name, surname, age2, city, email, phone, username, password);
        }
        return null!;
    }
}
