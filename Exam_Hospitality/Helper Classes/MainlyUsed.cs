using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;
using Exam_Hospitality.Button;
using Exam_Hospitality.DataBase;
using Exam_Hospitality.Exceptions;
using Exam_Hospitality.Json;
using System.Diagnostics;

namespace Exam_Hospitality;

public class MainlyUsed
{

    #region InAdminButton


    public static void AddDoctor()
    {
        // // Bos olan zaman bu isleyecek
        // GlobalData.databaseDoctor.Doctors.Add(doctor);
        // JsonSerialization.SerializeDatabaseDoctor(GlobalData.databaseDoctor);


        var choice = Cursor.ShowProfessionMenu();
        Doctor doctor = Doctor.SignUp();
        DataBaseForDoctors baseForDoctors = JsonSerialization.DeserializeDatabaseDoctor();

        switch (choice)
        {
            case 0:
                doctor.Profession = "Pediatrics";
                break;
            case 1:
                doctor.Profession = "Traumatology";
                break;
            case 2:
                doctor.Profession = "Dentistry";
                break;
            case 3:
                doctor.Profession = "Dietolog";
                break;
            case 4:
                doctor.Profession = "Psixiatr";
                break;
            case 5:
                doctor.Profession = "Rentgenolog";
                break;
        }

        baseForDoctors.Doctors.Add(doctor);

        JsonSerialization.SerializeDatabaseDoctor(baseForDoctors);
        VisualHelper.ShowSuccessfullyAdded();
        Thread.Sleep(4000);
    }

    public static void ShowDoctorFull()
    {
        VisualHelper.ShowDoctorScript();
        Thread.Sleep(1500);
        DataBaseForDoctors baseForDoctors = JsonSerialization.DeserializeDatabaseDoctor();
        ShowAllDoctor(baseForDoctors);
        Thread.Sleep(3000);
    }

    public static void EditDoctorData()
    {
        DataBaseForDoctors editDoctors = JsonSerialization.DeserializeDatabaseDoctor();
        ShowAllDoctor(editDoctors);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("ENTER THE NAME AND SURNAME OF THE DOCTOR TO BE CORRECTED: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string doctorFullname = Console.ReadLine()!;
        Console.ResetColor();


        foreach (var edit in editDoctors.Doctors)
        {
            if (edit?.Name?.ToLower() == doctorFullname.Split()[0].ToLower() && edit?.Surname?.ToLower() == doctorFullname.Split()[1].ToLower())
            {
                Console.Clear();
                Console.WriteLine(edit);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("#########################################################################");
                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n ENTER YOUR EMAIL : ");
                Console.ForegroundColor = ConsoleColor.Green;
                edit.Email = Console.ReadLine()!.Trim();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@" PHONE NUMBER EXAMPLES : 
    111 222 3344
    1234567890
    +1234567890
    +123-456-7890
    123-456-7890
    123-456-27890");

                Console.Write("\n ENTER YOUR PHONE NUMBER : ");
                Console.ForegroundColor = ConsoleColor.Green;
                edit.Phone = Console.ReadLine()!.Trim();


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n ENTER YOUR EXPERIENCE : ");
                Console.ForegroundColor = ConsoleColor.Green;
                string exper = Console.ReadLine()!.Trim();
                byte.TryParse(exper, out byte exper2);
                edit.Experience = exper2;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n ENTER YOUR DEGREE OF EDUCATION : ");
                Console.ForegroundColor = ConsoleColor.Green;
                edit.DegreeOfEducation = Console.ReadLine()!.Trim();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n ENTER YOUR CERTIFICATE : ");
                Console.ForegroundColor = ConsoleColor.Green;
                string certificate = Console.ReadLine()!.Trim();
                bool.TryParse(certificate, out bool certificate2);
                edit.Certificate = certificate2;

                JsonSerialization.SerializeDatabaseDoctor(editDoctors);
                break;
            }
        }
    }

    public static void DeleteDoctor()
    {
        DataBaseForDoctors deleteDoctors = JsonSerialization.DeserializeDatabaseDoctor();
        ShowAllDoctor(deleteDoctors);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("CHOOSE THE DOCTOR AND ENTER HIS/HER FULLNAME: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string doctorFullname = Console.ReadLine()!;
        Console.ResetColor();


        foreach (var doctor1 in deleteDoctors.Doctors)
        {
            if (doctor1?.Name?.ToLower() == doctorFullname.Split()[0].ToLower() && doctor1?.Surname?.ToLower() == doctorFullname.Split()[1].ToLower())
            {
                deleteDoctors.Doctors.Remove(doctor1);
                JsonSerialization.SerializeDatabaseDoctor(deleteDoctors);
                VisualHelper.ShowSuccessfullyDeleted();
                Thread.Sleep(3000);
                break;
            }
        }
    }

    #endregion


    public static Admin SignUpButton()
    {
        Admin admin;
        Console.Clear();
        VisualHelper.ShowSignUpHeadline();
        admin = SignUP.SignUp();

        // // Ilk defe ucun
        // GlobalData.databaseAdmin.Admins.Add(admin);
        // JsonSerialization.SerializeDatabaseAdmin(GlobalData.databaseAdmin);

        DatabaseForAdmin databaseForAdmin = JsonSerialization.DeserializeDatabaseAdmin();
        databaseForAdmin.Admins.Add(admin);
        JsonSerialization.SerializeDatabaseAdmin(databaseForAdmin);

        Console.Clear();
        VisualHelper.ShowQeydiyyatdanKecdiz();
        return admin;
    }

    #region ForPasientSignIn

    private static bool IsValidAge(string age)
    {
        bool converted = byte.TryParse(age, out byte intAge);
        if (converted)
            if (intAge >= 0)
                return true;
        return false;
    }

    private static bool CheckLength(string str) => str.Length >= 4;

    private static bool CheckLengthPhone(string str) => str.Length >= 8;

    private static bool CheckEmail(string str) => str.EndsWith("@gmail.com") || str.EndsWith("@mail.ru") && str.Length > 8;


    private static bool ValidInfos(string name, string surname, string age, string email, string city, string phoneNumber, string complaint)
    {
        StackFrame callStack = new StackFrame(1, true);
        string currentFile = new StackTrace(true).GetFrame(0)!.GetFileName()!;

        // Check null or empty
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(age)
         || string.IsNullOrEmpty(complaint) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(city)
         || string.IsNullOrEmpty(phoneNumber))
        {
            Warning.Message("ALL INFORMATIONS WERE NOT ENTERED!");
            throw new DetailedException("All Informations Were Not Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile);
        }

        // Chedck Length
        if (!CheckLength(name))
        {
            Warning.Message("INCORRECT NAME LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect Name length Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(surname))
        {
            Warning.Message("INCORRECT SURNAME LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect surname length Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(city))
        {
            Warning.Message("INCORRECT CITY LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect city Was length Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLength(complaint))
        {
            Warning.Message("INCORRECT EDUCATION LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect education length Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        if (!CheckLengthPhone(phoneNumber))
        {
            Warning.Message("INCORRECT PHONE NUMBER LENGTH WAS ENTERED!");
            throw new DetailedException("Incorrect phoneNumber Was length Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        // Check Email
        if (!CheckEmail(email))
        {
            Warning.Message("INCORRECT EMAIL WAS ENTERED!");
            throw new DetailedException("Incorrect emaail Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }


        // Check Age
        if (!IsValidAge(age))
        {
            Warning.Message("INCORRECT AGE WAS ENTERED!");
            throw new DetailedException("Incorrect Age Was Entered!", DateTime.Now, callStack.GetFileLineNumber(), currentFile!);
        }

        return true;
    }

    public static Pasient PasientSignIn()
    {
        while (true)
        {
            Console.Clear();
            VisualHelper.EnterData();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine()!;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Surname: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string surname = Console.ReadLine()!;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Age: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string age = Console.ReadLine()!;



            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Email: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string email = Console.ReadLine()!;



            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Phone number: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string phone = Console.ReadLine()!;



            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("City: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string city = Console.ReadLine()!;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Complaint: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string complaint = Console.ReadLine()!;

            try
            {
                if (ValidInfos(name, surname, age, email, city, phone, complaint))
                {
                    byte.TryParse(age, out byte age2);

                    return new Pasient(name, surname, age2, city, email, phone, complaint);
                }
            }
            catch (DetailedException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }

    #endregion


    private static List<Doctor> Data()
    {
        Console.ResetColor();


        List<InspectionTime> inspectionTime = new List<InspectionTime>()
    {
        new InspectionTime("09:00-11:00"),
        new InspectionTime("12:00-14:00"),
        new InspectionTime("15:00-17:00")

    };

        List<Doctor> allDoctor = new()
        {
        new Doctor("Veronica","Wheel", 35,"London", "VeronicaWheel@mail.ru","+404 965 65 48", 5,"Bachelor",true,"Pediatrics",new List<InspectionTime>(inspectionTime)),
        new Doctor("Leon","Amsterdam", 55,"Amsterdam", "leonamster233@gmail.com","+350 123 95 38", 20,"Aspirantura",true,"Pediatrics",new List<InspectionTime>(inspectionTime)),
        new Doctor("Ehmed","Nagili", 28,"Baku", "bombaoglan233@gmail.com","+994 325 15 05", 1,"Intern",false,"Pediatrics", new List<InspectionTime>(inspectionTime)),
        new Doctor("Timy","Albert",45,"Vasington","barakobama233@gmail.com","+852 368 152",15,"Master",false,"Traumatology",new List<InspectionTime>(inspectionTime)),
        new Doctor("Seol","Nicers",35,"Seol","snicerks233@mail.ru","+159 753 258",7,"Bachelor",false,"Traumatology",new List<InspectionTime>(inspectionTime)),
        new Doctor("Orkun","Kokcu",65,"Ankara","orkunkok16523@gmail.com","+159 852 357",35,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Aleksey","Medmedev",57,"Sank Peterbruk","aleksey1423@mail.ru","+7 3685 15 52",32,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Ibn","Sina",76,"Tabriz","ibnsina214456@gmail.com","+9 13 685  192",50,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Kamran","Karimli",23,"Sabuncu","ka5mran1234@gmail.com","+994 70 123 45 67",1,"Intern",false,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Hocet","Haqverdi",35,"Tebriz","haqverdi@gmail.com","+659 452 357",10,"Bachelor",true,"Dietolog",new List<InspectionTime>(inspectionTime)),
        new Doctor("Filip","Ozobic",42,"Zaqreb","f.ozobic@gmail.com","+965 123 226",17,"Master",true,"Dietolog",new List<InspectionTime>(inspectionTime)),
        new Doctor("Mehriban", "Hasanova",48,"Sumqayit","m.hasanova@gmail.com","+994 77 211 11 11", 28,"Master",true,"Psixiatr",new List<InspectionTime>(inspectionTime)),
        new Doctor("Eldeniz", "Ismayilov",56,"Sabuncu","i.eldeniz95@gmail.com","+994 55 511 51 51", 38,"Scholar",true,"Psixiatr",new List<InspectionTime>(inspectionTime)),
        new Doctor("Abdulla", "Qasamov", 68,"Xetai","q.abdulla54@gmail.com","+994 50 311 21 21", 48,"Scholar",true,"Rentgenolog",new List<InspectionTime>(inspectionTime)),
        new Doctor("Albert", "Oliver", 28,"Berlin","oliverAlbert@mail.ru","+999 215 101 31 91", 3,"Internr",true,"Rentgenolog",new List<InspectionTime>(inspectionTime))
        };
        return allDoctor;
    }

    public static void CheckDoctorSobe(DataBaseForDoctors dataBaseForDoctors, List<Doctor> doctors, string data)
    {
        foreach (var doctor in dataBaseForDoctors.Doctors)
        {
            if (doctor.Profession == data)
                doctors.Add(doctor);
        }
    }

    public static void ShowAllDoctor(DataBaseForDoctors database)
    {

        foreach (Doctor doctor in database.Doctors)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(doctor);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();
            Thread.Sleep(400);
        }
    }
}