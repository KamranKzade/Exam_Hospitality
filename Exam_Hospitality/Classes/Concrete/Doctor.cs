using Exam_Hospitality.Classes.Abstract;
using Exam_Hospitality.Exceptions;
using System.Diagnostics;

namespace Exam_Hospitality.Classes.Concrete;


public sealed class Doctor : Human
{
    public List<InspectionTime> InspectionTimes;
    public bool Certificate { get; set; }

    public byte Experience { get; set; }

    public string? DegreeOfEducation { get; set; }
    public string? Profession { get; set; }

    public Doctor()
    {

    }

    public Doctor(string? name, string? surname, byte age, string? city, string? email, string? phone, byte experience, string? education, bool certicate, string profession, List<InspectionTime> inspectionTimes)
       : base(name, surname, age, city, email, phone)
    {
        Experience = experience;
        DegreeOfEducation = education;
        Certificate = certicate;
        Profession = profession;
        InspectionTimes = inspectionTimes;
    }

    public static Doctor SignUp()
    {
        while (true)
        {
            Console.Clear();
            VisualHelper.EnterDataDoctor();
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
            Console.Write("\n ENTER YOUR CITY : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string city = Console.ReadLine()!.Trim();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR EMAIL : ");
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

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR EXPERIENCE : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string experience = Console.ReadLine()!.Trim();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR DEGREE OF EDUCATION : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string education = Console.ReadLine()!.Trim();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR CERTIFICATE : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string certicate = Console.ReadLine()!.Trim();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n ENTER YOUR PROFESSION : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string profession = Console.ReadLine()!.Trim();

            Console.CursorVisible = false;

            List<InspectionTime> inspectionTime = new List<InspectionTime>()
    {
        new InspectionTime("09:00-11:00"),
        new InspectionTime("12:00-14:00"),
        new InspectionTime("15:00-17:00")
    };
            Console.CursorVisible = false;
            try
            {
                if (ValidInfos(name, surname, age, email, city, phone, experience, education, certicate, profession))
                {
                    byte.TryParse(age, out byte age2);
                    byte.TryParse(experience, out byte experience2);
                    bool.TryParse(certicate, out bool certicate2);
                    return new Doctor(name, surname, age2, city, email, phone, experience2, education, certicate2, profession, inspectionTime);
                }
            }
            catch (DetailedException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }

    private static bool ValidInfos(string name, string surname, string age, string email, string city, string phoneNumber, string experience, string education, string certicate, string profession)
    {
        StackFrame callStack = new StackFrame(1, true);
        string currentFile = new StackTrace(true).GetFrame(0)!.GetFileName()!;

        // Check null or empty
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(age)
         || string.IsNullOrEmpty(education) || string.IsNullOrEmpty(profession) || string.IsNullOrEmpty(city)
         || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(experience) || string.IsNullOrEmpty(certicate))
        {
            Warning.Message("ALL INFORMATIONS WERE NOT ENTERED!");
            throw new DetailedException("All Informations Were Not Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile);
        }

        // Chedck Length
        if (!CheckLength(name))
        {
            Warning.Message("INCORRECT NAME LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect Name length Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(surname))
        {
            Warning.Message("INCORRECT SURNAME LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect surname length Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(city))
        {
            Warning.Message("INCORRECT CITY LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect city Was length Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(education))
        {
            Warning.Message("INCORRECT EDUCATION LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect education length Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(profession))
        {
            Warning.Message("INCORRECT PROFESSION LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect profession Was length Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLengthPhone(phoneNumber))
        {
            Warning.Message("INCORRECT PHONE NUMBER LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect phoneNumber Was length Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }


        // Check Email
        if (!CheckEmail(email))
        {
            Warning.Message("INCORRECT EMAIL WAS ENTERED!");
            throw new DetailedException("Incorrect emaail Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }


        // Check Age
        if (!IsValidAge(age))
        {
            Warning.Message("INCORRECT AGE WAS ENTERED!");
            throw new DetailedException("Incorrect Age Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        // Check Certificate
        if (!IsValidAge(certicate))
        {
            Warning.Message("INCORRECT CERTIFICATE WAS ENTERED!");
            throw new DetailedException("Incorrect certicate Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        return true;
    }

    private static bool IsValidAge(string age)
    {
        bool converted = byte.TryParse(age, out byte intAge);
        if (converted)
            if (intAge >= 0)
                return true;
        return false;
    }
    private static bool CheckLength(string str)
    {
        if (str.Length >= 4)
            return true;
        return false;
    }
    private static bool CheckLengthPhone(string str)
    {
        if (str.Length >= 8)
            return true;
        return false;
    }
    private static bool CheckEmail(string str)
    {
        if (str.EndsWith("@gmail.com") || str.EndsWith("@mail.ru") && str.Length > 8)
            return true;
        return false;
    }

    public override string ToString()
    {


        Console.WriteLine($"{base.ToString()}");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Experience: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Experience}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("DegreeOfEducation: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{DegreeOfEducation}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Profession: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Profession}\n");


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Certificate: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Certificate}\n\n");

        Console.ResetColor();
        return "";
    }
}