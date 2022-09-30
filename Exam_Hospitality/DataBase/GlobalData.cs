using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality.DataBase;

public static class GlobalData
{
    public static DatabaseForAdmin databaseAdmin = new ();
    public static DataBaseForDoctors databaseDoctor = new ();
};
