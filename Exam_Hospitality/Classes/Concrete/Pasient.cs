using Exam_Hospitality.Classes.Abstract;


namespace Exam_Hospitality.Classes.Concrete;

public class  Pasient : Human
{
    // Sikayet 
    private string? _complaint;
    public string? Complaint
    {
        get { return _complaint; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                throw new ArgumentNullException("Enter Complaint, again");
            _complaint = value;
        }
    }


    public Pasient(string? name, string? surname, byte age, string? city, string? email, string? phone, string? sikayet)
        : base(name, surname, age, city, email, phone)
    {
        Complaint = sikayet;
    }


    public override string ToString()
        => @$"{base.ToString()}
Complaint: {Complaint}
";

}