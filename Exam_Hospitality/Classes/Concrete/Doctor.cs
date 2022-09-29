using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Abstract;


namespace Exam_Hospitality.Classes.Concrete;


public class Doctor : Human
{
   public  List<InspectionTime> InspectionTimes;
    public bool Certificate { get; set; }


    private byte _experience;
    public byte Experience
    {
        get { return _experience; }
        set
        {
            if (value < _experience)
                throw new ArgumentException("Incorrect Information");

            _experience = value;
        }
    }

    private string? _education;
    public string? DegreeOfEducation
    {
        get { return _education; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                throw new ArgumentException("Enter DegreeOfEducation, again");

            _education = value;
        }
    }

    // Sobe
    private string? _profession;
    public string? Profession
    {
        get { return _profession; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                throw new ArgumentException("Enter Profession, again");

            _profession = value;
        }
    }

    public  Doctor(string? name, string? surname, byte age, string? city, string? email, string? phone, byte experience, string? education, bool certicate, string? profession, List<InspectionTime> inspectionTimes)
        : base(name, surname, age, city, email, phone)
    {
        Experience = experience;
        DegreeOfEducation = education;
        Certificate = certicate;
        Profession = profession;
        InspectionTimes = inspectionTimes;
    }

    public override string ToString()
 => $@"{base.ToString()}
Experience: {Experience}
DegreeOfEducation: {DegreeOfEducation}
Certificate: {Certificate}
";
}