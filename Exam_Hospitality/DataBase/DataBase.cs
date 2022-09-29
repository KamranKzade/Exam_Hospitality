using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;



namespace Exam_Hospitality.DataBase;

public class Database
{
    public List<Admin> Admins { get; set; } = new List<Admin>();
    public List<Doctor> Doctors { get; set; } = new List<Doctor>();

    public Database(List<Admin> admins, List<Doctor> doctors)
    {
        Admins = admins;
        Doctors = doctors;
    }
    public Database()
    {

    }

    public static Admin GetAdmin(string username)
    {
        foreach (var admin in GlobalData.database.Admins)
        {
            if (admin.UserName == username)
            {
                return admin;
            }
        }
        return null!;
    }

}
