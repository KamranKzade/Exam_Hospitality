using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;



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
