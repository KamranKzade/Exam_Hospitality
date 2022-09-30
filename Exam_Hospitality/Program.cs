using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.DataBase;

namespace Exam_Hospitality;

class Program
{

    static void Main()
    {
        while (true)
        {


            var location = Cursor.ShowStartMenu();

            if (location == 0)
            {
                MainlyUsed.AdminButton();



            }

            else
            {
                MainlyUsed.Rezerv();

            }
        }
    }
}