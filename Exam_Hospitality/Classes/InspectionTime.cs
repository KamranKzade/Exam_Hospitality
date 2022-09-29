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
    public override string ToString()
    => $@"Time: {Time}
Rezerv: {(Rezerv is null ? "No" : "Yes")}";

}