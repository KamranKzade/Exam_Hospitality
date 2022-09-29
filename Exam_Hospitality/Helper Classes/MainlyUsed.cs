using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;
using Exam_Hospitality.DataBase;
using Exam_Hospitality.Json;




namespace Exam_Hospitality;

public class MainlyUsed
{
    public static void AdminButton()
    {
        Admin admin = new();
        int counter = 0;
        const int size = 3;
        ConsoleColor[] Set = new ConsoleColor[size] { ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow };
        Console.CursorVisible = false;
        while (true)
        {
            Console.Clear();
            Console.ResetColor();
            for (int i = 0; i < size; i++)
            {
                if (i == counter)
                    Set[i] = ConsoleColor.Red;
                else
                    Set[i] = ConsoleColor.Yellow;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            VisualHelper.ShowAdmin();
            Console.ForegroundColor = Set[0];
            VisualHelper.ShowSignInScript();
            Console.ForegroundColor = Set[1];
            VisualHelper.ShowSignUpScript();
            Console.ForegroundColor = Set[2];
            VisualHelper.ShowBackScript();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("");

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow && counter != 0)
            {
                counter--;
            }
            else if (key.Key == ConsoleKey.DownArrow && counter != size - 1)
            {
                counter++;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                if (counter == 0)
                {
                    Console.Clear();
                    VisualHelper.ShowSignInHeadline();
                    SignIN.SignIn();

                    Console.Clear();
                    VisualHelper.ShowWelcome();
                    Thread.Sleep(10000);



                }

                else if (counter == 1)
                    admin = SignUpButton();
                else
                    break;
            }
            Console.CursorVisible = false;
        }
    }

    public static Admin SignUpButton()
    {
        Admin admin;
        Console.Clear();
        VisualHelper.ShowSignUpHeadline();
        admin = SignUP.SignUp();
        GlobalData.database.Admins.Add(admin);
        JsonSerialization.SerializeDatabase(GlobalData.database);

        Console.Clear();
        VisualHelper.ShowQeydiyyatdanKecdiz();
        return admin;
    }

    public static void PasientSignIn(out string name, out string surname, out byte age, out string email, out string phone, out string city, out string complaint)
    {
        Console.Clear();
        VisualHelper.EnterData();


        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Name: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        name = Console.ReadLine()!;


        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Surname: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        surname = Console.ReadLine()!;


        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Age: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        age = Convert.ToByte(Console.ReadLine()!);



        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Email: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        email = Console.ReadLine()!;
        
        
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Phone number: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        phone = Console.ReadLine()!;
        
        
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("City: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        city = Console.ReadLine()!;
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Complaint: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        complaint = Console.ReadLine()!;
    }

    public static void Data(out List<Doctor> pediatricsDoctors, out List<Doctor> traumatologyDoctors, out List<Doctor> dentistryDoctors)
    {
        Console.ResetColor();
        List<InspectionTime> inspectionTime = new List<InspectionTime>()
    {
        new InspectionTime("09:00-11:00"),
        new InspectionTime("12:00-14:00"),
        new InspectionTime("15:00-17:00")

    };

        pediatricsDoctors = new()
    {
        new Doctor("Veronica","Wheel", 35,"London", "VeronicaWheel@mail.ru","+404 965 65 48", 5,"Bacelor",true,"Pediatrics",new List<InspectionTime>(inspectionTime)),
        new Doctor("Leon","Amsterdam", 55,"Amsterdam", "leonamster233@gmail.com","+350 123 95 38", 20,"Aspirantura",true,"Pediatrics",new List<InspectionTime>(inspectionTime)),
        new Doctor("Ehmed","Nagili", 28,"Baku", "bombaoglan233@gmail.com","+994 325 15 05", 1,"Intern",false,"Pediatrics", new List<InspectionTime>(inspectionTime)),
    };
        traumatologyDoctors = new()
    {
        new Doctor("Timy","Albert",45,"Vasington","barakobama233@gmail.com","+852 368 152",15,"Master",false,"Traumatology",new List<InspectionTime>(inspectionTime)),
        new Doctor("Seol","Nicers",35,"Seol","snicerks233@mail.ru","+159 753 258",7,"Bacelor",false,"Traumatology",new List<InspectionTime>(inspectionTime)),
    };
        dentistryDoctors = new List<Doctor>()
    {
        new Doctor("Orkun","Kokcu",65,"Ankara","orkunkok16523@gmail.com","+159 852 357",35,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Aleksey","Medmedev",57,"Sank Peterbruk","aleksey1423@mail.ru","+7 3685 15 52",32,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Ibn","Sina",76,"Tabriz","ibnsina214456@gmail.com","+9 13 685  192",50,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Kamran","Karimli",23,"Sabuncu","ka5mran1234@gmail.com","+994 70 123 45 67",1,"Intern",false,"Dentistry",new List<InspectionTime>(inspectionTime))
    };
    }

}
