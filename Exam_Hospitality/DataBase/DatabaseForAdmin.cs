using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;



namespace Exam_Hospitality.DataBase;

public class DatabaseForAdmin
{
    public List<Admin> Admins { get; set; } = new List<Admin>();

    public DatabaseForAdmin(List<Admin> admins)
    {
        Admins = admins;
    }
    public DatabaseForAdmin()
    {

    }
}
