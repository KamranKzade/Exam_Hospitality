using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality.DataBase
{
    public class Database
    {
        public List<Admin> Admins { get; set; } = new List<Admin>();

        public Database(List<Admin> admins)
        {
            Admins = admins;
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
            return null;
        }

    }
}
