using Exam_Hospitality.Classes.Abstract;

namespace Exam_Hospitality.Classes.Concrete;


public sealed class Doctor : Human
{
    public List<InspectionTime> InspectionTimes;
    public bool Certificate { get; set; }

    public byte Experience { get; set; }

    public string? DegreeOfEducation { get; set; }
    public string? Profession { get; set; }

    public Doctor(string? name, string? surname, byte age, string? city, string? email, string? phone, byte experience, string? education, bool certicate, string? profession, List<InspectionTime> inspectionTimes)
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

        byte.TryParse(age, out byte age2);
        byte.TryParse(experience, out byte experience2);
        bool.TryParse(certicate, out bool certicate2);

        return new Doctor(name, surname, age2, city, email, phone, experience2, education, certicate2, profession, inspectionTime);

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