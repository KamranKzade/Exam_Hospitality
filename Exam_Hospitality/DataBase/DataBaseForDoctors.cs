using Exam_Hospitality.Classes.Concrete;



namespace Exam_Hospitality.DataBase;

public class DataBaseForDoctors
{
    public List<Doctor> Doctors { get; set; } = new();

    public DataBaseForDoctors( List<Doctor> doctors)
    {
        Doctors = doctors;
    }
    public DataBaseForDoctors()
    {

    }
}
