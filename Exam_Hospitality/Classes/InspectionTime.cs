using Exam_Hospitality.Classes.Concrete;



namespace Exam_Hospitality.Classes;

public struct InspectionTime
{
    public string? Time { get; set; }


    public Pasient? Rezerv { get; set; } = null;
    public InspectionTime(string time)
    {
        Time = time;
    }
   
    //    public override string ToString()
    //    => $@"Time: {Time}
    //Rezerv: {(Rezerv is null ? "No" : "Yes")}";

    public override string ToString()
    {
       

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Time: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{Time}\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Rezerv: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{(Rezerv is null ? "No" : "Yes")}\n");

        return "";
    }

}