using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Concrete;

namespace Exam_Hospitality;

class Program
{

    static void Main()
    {

        var location = Cursor.ShowStartMenu();

        if (location == 0)
        {
            Cursor.ShowAdminMenu();
        }

        else
        {
            List<Doctor> pediatricsDoctors, traumatologyDoctors, dentistryDoctors;
            Data(out pediatricsDoctors, out traumatologyDoctors, out dentistryDoctors);

            Doctor currentDoctor;
            string doctorFullname, time;
            bool isReserved = false, hasFreeTime = false;

            while (true)
            {
                Console.Clear();

                currentDoctor = null!;

                string name, surname, email, phone, city, complaint;
                byte age;

                PasientSignIn(out name, out surname, out age, out email, out phone, out city, out complaint);

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

                Console.WriteLine(@"Which specialist do you need?
            1) Pediatrics
            2) Traumotology
            3) Dentistry");

                if (!int.TryParse(Console.ReadLine(), out int command))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.ReadKey(false);
                    continue;
                }

                List<Doctor> doctors = null!;

                switch (command)
                {
                    case 1:
                        doctors = pediatricsDoctors;
                        break;
                    case 2:
                        doctors = traumatologyDoctors;
                        break;
                    case 3:
                        doctors = dentistryDoctors;
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        Console.ReadKey(false);
                        continue;
                }


                while (true)
                {
                    Console.Clear();
                    foreach (var doctor in doctors)
                        Console.WriteLine(doctor);

                    Console.WriteLine("Choose the doctor and enter his/her fullname");
                    doctorFullname = Console.ReadLine()!;

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
                        Console.WriteLine("Such doctor not found please enter correct information");
                        Console.ReadKey(false);
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Clear();
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
                        break;
                    }

                    foreach (var receptionTime in currentDoctor.InspectionTimes)
                        Console.WriteLine(receptionTime);

                    Console.WriteLine("Choose the reception time");
                    time = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(time) || time.Length != 11)
                    {
                        Console.WriteLine("Entered wrong information");
                        Console.ReadKey(false);
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
                                Console.WriteLine("Reserved succesfully");
                                Console.ReadKey(false);
                            }
                            else
                            {
                                Console.WriteLine("This time is reserved please choose another one");
                                Console.ReadKey(false);
                            }
                            break;
                        }
                    }

                    if (isReserved)
                        break;
                }
            }
        }

    }




    private static void PasientSignIn(out string name, out string surname, out byte age, out string email, out string phone, out string city, out string complaint)
    {
        Console.WriteLine("Welcome to Oxsigen");
        Thread.Sleep(1500);

        Console.WriteLine("Please enter your data");

        Console.Write("Name: ");
        name = Console.ReadLine()!;
        Console.Write("Surname: ");
        surname = Console.ReadLine()!;
        Console.Write("Age: ");
        age = Convert.ToByte(Console.ReadLine()!);
        Console.Write("Email: ");
        email = Console.ReadLine()!;
        Console.Write("Phone number: ");
        phone = Console.ReadLine()!;
        Console.Write("City: ");
        city = Console.ReadLine()!;
        Console.Write("Sikayet: ");
        complaint = Console.ReadLine()!;
    }

    private static void Data(out List<Doctor> pediatricsDoctors, out List<Doctor> traumatologyDoctors, out List<Doctor> dentistryDoctors)
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