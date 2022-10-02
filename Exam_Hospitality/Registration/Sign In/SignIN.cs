using Exam_Hospitality.DataBase;
using Exam_Hospitality.Exceptions;
using Exam_Hospitality.Json;
using System.Collections;
using System.Diagnostics;

namespace Exam_Hospitality;

public class SignIN
{
    public static ArrayList GetUser(string username, string password)
    {
        GlobalData.databaseAdmin = JsonSerialization.DeserializeDatabaseAdmin();

        StackFrame callStack = new StackFrame(1, true);
        string currentFile = new StackTrace(true).GetFrame(0)!.GetFileName()!;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            Warning.Message("ALL INFORMATIONS WERE NOT ENTERED!");
            throw new DetailedException("All Informations Were Not Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile);
        }

        if (GlobalData.databaseAdmin.Admins != null)
        {
            foreach (var admin in GlobalData.databaseAdmin.Admins)
            {
                if (admin.UserName == username && admin.Password == password)
                {
                    ArrayList arrayList = new();
                    arrayList.Add(admin);
                    return arrayList;
                }
            }
        }

        // Show to user
        Warning.Message("INCORRECT USERNAME OR PASSWORD! USER WAS NOT FOUND!");
        throw new DetailedException($"The user '{username}' with password '{password}' was not found!", DateTime.Now, callStack.GetFileLineNumber(), currentFile);
    }

    public static ArrayList SignIn()
    {
        while (true)
        {
            Console.Clear();
            VisualHelper.ShowSignInHeadline();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR USERNAME : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string username = Console.ReadLine()!.Trim();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR PASSWORD : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string password = Console.ReadLine()!.Trim();

            try
            {
                ArrayList user = GetUser(username, password);
                return user;
            }
            catch (DetailedException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ReadKey();                
                Console.ResetColor();
            }
        }
    }
}