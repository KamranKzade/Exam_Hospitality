namespace Exam_Hospitality.Classes.Abstract;




abstract public class Human
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public byte Age { get; set; }
    public string? City { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public Human()
    {

    }

    public Human(string? name, string? surname, byte age, string? city, string? email, string? phone)
    {
        Name = name;
        Surname = surname;
        Age = age;
        City = city;
        Email = email;
        Phone = phone;
    }


    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Name: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Name}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Surname: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Surname}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Age: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Age}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("City: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{City}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Email: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Email}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Phone: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Phone}\n");

        Console.ResetColor();
        return "";
    }

}