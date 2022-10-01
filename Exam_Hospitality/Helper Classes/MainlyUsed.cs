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
                    int counter2 = 0;
                    Console.Clear();
                    VisualHelper.ShowSignInHeadline();
                    SignIN.SignIn();
                    counter2 = Cursor.ShowSignInChoiceMenu();

                    Console.Clear();



                    switch (counter2)
                    {
                        case 0:
                            AddDoctor();
                            break;
                        case 1:
                            ShowDoctorFull();
                            break;
                        case 2:
                            EditDoctorData();
                            Console.WriteLine("Edit");
                            break;
                        case 3:
                            DeleteDoctor();
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                }

                else if (counter == 1)
                    admin = SignUpButton();
                else
                    break;
            }
            Console.CursorVisible = false;
        }
    }

    private static void EditDoctorData()
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

    private static void DeleteDoctor()
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

    private static void ShowDoctorFull()
    {
        VisualHelper.ShowDoctorScript();
        Thread.Sleep(1500);
        DataBaseForDoctors baseForDoctors = JsonSerialization.DeserializeDatabaseDoctor();
        ShowAllDoctor(baseForDoctors);
        Thread.Sleep(3000);
    }

    private static void AddDoctor()
    {
        var doctor = Doctor.SignUp();


        // // Bos olan zaman bu isleyecek
        // LoadData();
        // GlobalData.databaseDoctor.Doctors.Add(doctor);
        // JsonSerialization.SerializeDatabaseDoctor(GlobalData.databaseDoctor);


        DataBaseForDoctors baseForDoctors = JsonSerialization.DeserializeDatabaseDoctor();
        baseForDoctors.Doctors.Add(doctor);
        JsonSerialization.SerializeDatabaseDoctor(baseForDoctors);

        VisualHelper.ShowSuccessfullyAdded();
        Thread.Sleep(2000);
    }

    private static Admin SignUpButton()
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

    private static void PasientSignIn(out string name, out string surname, out byte age, out string email, out string phone, out string city, out string complaint)
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

    private static void Data(out List<Doctor> pediatricsDoctors, out List<Doctor> traumatologyDoctors, out List<Doctor> dentistryDoctors, out List<Doctor> dietologDoctors, out List<Doctor> psixiatrDoctors, out List<Doctor> rentgenologDoctors)
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
        new Doctor("Veronica","Wheel", 35,"London", "VeronicaWheel@mail.ru","+404 965 65 48", 5,"Bachelor",true,"Pediatrics",new List<InspectionTime>(inspectionTime)),
        new Doctor("Leon","Amsterdam", 55,"Amsterdam", "leonamster233@gmail.com","+350 123 95 38", 20,"Aspirantura",true,"Pediatrics",new List<InspectionTime>(inspectionTime)),
        new Doctor("Ehmed","Nagili", 28,"Baku", "bombaoglan233@gmail.com","+994 325 15 05", 1,"Intern",false,"Pediatrics", new List<InspectionTime>(inspectionTime)),
    };
        traumatologyDoctors = new()
    {
        new Doctor("Timy","Albert",45,"Vasington","barakobama233@gmail.com","+852 368 152",15,"Master",false,"Traumatology",new List<InspectionTime>(inspectionTime)),
        new Doctor("Seol","Nicers",35,"Seol","snicerks233@mail.ru","+159 753 258",7,"Bachelor",false,"Traumatology",new List<InspectionTime>(inspectionTime)),
    };
        dentistryDoctors = new List<Doctor>()
    {
        new Doctor("Orkun","Kokcu",65,"Ankara","orkunkok16523@gmail.com","+159 852 357",35,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Aleksey","Medmedev",57,"Sank Peterbruk","aleksey1423@mail.ru","+7 3685 15 52",32,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Ibn","Sina",76,"Tabriz","ibnsina214456@gmail.com","+9 13 685  192",50,"Scholar",true,"Dentistry",new List<InspectionTime>(inspectionTime)),
        new Doctor("Kamran","Karimli",23,"Sabuncu","ka5mran1234@gmail.com","+994 70 123 45 67",1,"Intern",false,"Dentistry",new List<InspectionTime>(inspectionTime))
    };


        dietologDoctors = new List<Doctor>()
        {
        new Doctor("Hocet","Haqverdi",35,"Tebriz","haqverdi@gmail.com","+659 452 357",10,"Bachelor",true,"Dietolog",new List<InspectionTime>(inspectionTime)),
        new Doctor("Filip","Ozobic",42,"Zaqreb","f.ozobic@gmail.com","+965 123 226",17,"Master",true,"Dietolog",new List<InspectionTime>(inspectionTime))
        };

        psixiatrDoctors = new List<Doctor>()
        {
        new Doctor("Mehriban", "Hasanova",48,"Sumqayit","m.hasanova@gmail.com","+994 77 211 11 11", 28,"Master",true,"Psixiatr",new List<InspectionTime>(inspectionTime)),
        new Doctor("Eldeniz", "Ismayilov",56,"Sabuncu","i.eldeniz95@gmail.com","+994 55 511 51 51", 38,"Scholar",true,"Psixiatr",new List<InspectionTime>(inspectionTime))

        };

        rentgenologDoctors = new List<Doctor>()
        {
        new Doctor("Abdulla", "Qasamov", 68,"Xetai","q.abdulla54@gmail.com","+994 50 311 21 21", 48,"Scholar",true,"Rentgenolog",new List<InspectionTime>(inspectionTime)),
        new Doctor("Albert", "Oliver", 28,"Berlin","oliverAlbert@mail.ru","+999 215 101 31 91", 3,"Internr",true,"Rentgenolog",new List<InspectionTime>(inspectionTime))

        };

    }

    public static void Rezerv()
    {
        Console.Clear();
        VisualHelper.ShowWelcome();
        VisualHelper.ShowClinicName();
        Thread.Sleep(2000);


        List<Doctor> pediatricsDoctors, traumatologyDoctors, dentistryDoctors, dietologDoctors, psixiatrDoctors, rentgenologDoctors;
        MainlyUsed.Data(out pediatricsDoctors, out traumatologyDoctors, out dentistryDoctors, out dietologDoctors, out psixiatrDoctors, out rentgenologDoctors);

        Doctor currentDoctor;
        string doctorFullname, time;
        bool isReserved = false, hasFreeTime = false;

        while (true)
        {
            Console.Clear();

            currentDoctor = null!;

            string name, surname, email, phone, city, complaint;
            byte age;

            MainlyUsed.PasientSignIn(out name, out surname, out age, out email, out phone, out city, out complaint);
            Pasient pasient;

            try
            {
                pasient = new(name, surname, age, city, email, phone, complaint);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey(false);
                continue;
            }

            var choice = Cursor.ShowRezervMenu();

            List<Doctor> doctors = null!;

            switch (choice)
            {
                case 0:
                    doctors = pediatricsDoctors;
                    break;
                case 1:
                    doctors = traumatologyDoctors;
                    break;
                case 2:
                    doctors = dentistryDoctors;
                    break;
                case 3:
                    doctors = dietologDoctors;
                    break;
                case 4:
                    doctors = psixiatrDoctors;
                    break;
                case 5:
                    doctors = rentgenologDoctors;
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    Console.ReadKey(false);
                    continue;
            }


            while (true)
            {
                Console.Clear();
                VisualHelper.ShowDoctorScript();

                foreach (var doctor in doctors)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****************************************************************************");
                    Console.WriteLine(doctor);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****************************************************************************");
                    Thread.Sleep(2000);
                    Console.ResetColor();

                }


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Choose the doctor and enter his/her fullname: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                doctorFullname = Console.ReadLine()!;
                Console.ResetColor();

                foreach (var doctor in doctors)
                {
                    if (doctor?.Name?.ToLower() == doctorFullname.Split()[0].ToLower() && doctor?.Surname?.ToLower() == doctorFullname.Split()[1].ToLower())
                    {
                        currentDoctor = doctor;
                        break;
                    }
                }

                if (currentDoctor is null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Such doctor not found please enter correct information");
                    Console.ReadKey(false);
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                VisualHelper.ShowDoctorInfoScript();
                Console.WriteLine(currentDoctor);


                foreach (var receptionTime in currentDoctor.InspectionTimes)
                {
                    if (receptionTime.Rezerv is null)
                        hasFreeTime = true;
                }

                if (!hasFreeTime)
                {
                    Console.WriteLine("Doctor has not free time please choose another one");
                    Console.ReadKey(false);
                    Console.ResetColor();
                    break;
                }

                VisualHelper.ShowRecptionScript();
                foreach (var receptionTime in currentDoctor.InspectionTimes)
                    Console.WriteLine(receptionTime);


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose the reception time (Same time): ");
                Console.ForegroundColor = ConsoleColor.Red;
                time = Console.ReadLine()!;
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(time) || time.Length != 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entered wrong information");
                    Console.ReadKey(false);
                    Console.ResetColor();
                    continue;
                }


                for (int i = 0; i < currentDoctor.InspectionTimes.Count; i++)
                {
                    if (currentDoctor.InspectionTimes[i].Time == time)
                    {
                        if (currentDoctor.InspectionTimes[i].Rezerv is null)
                        {
                            InspectionTime temp = currentDoctor.InspectionTimes[i];
                            temp.Rezerv = pasient;
                            currentDoctor.InspectionTimes[i] = temp;
                            isReserved = true;
                            Console.Clear();
                            VisualHelper.ShowSuccesfully();

                            Console.ReadKey(false);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This time is reserved please choose another one");
                            Console.ReadKey(false);
                            Console.ResetColor();
                        }
                        break;
                    }
                }

                if (isReserved)
                    break;


            }
        }

    }

    private static void LoadData()
    {
        List<Doctor> pediatricsDoctors, traumatologyDoctors, dentistryDoctors, dietologDoctors, psixiatrDoctors, rentgenologDoctors;
        Data(out pediatricsDoctors, out traumatologyDoctors, out dentistryDoctors, out dietologDoctors, out psixiatrDoctors, out rentgenologDoctors);

        AddDoctorFunctor(pediatricsDoctors);
        AddDoctorFunctor(traumatologyDoctors);
        AddDoctorFunctor(dentistryDoctors);
        AddDoctorFunctor(dietologDoctors);
        AddDoctorFunctor(psixiatrDoctors);
        AddDoctorFunctor(rentgenologDoctors);

    }

    private static void AddDoctorFunctor(List<Doctor> doctors)
    {
        foreach (Doctor doctor in doctors)
        {
            GlobalData.databaseDoctor.Doctors.Add(doctor);
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