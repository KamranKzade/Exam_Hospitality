using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Concrete;
using Exam_Hospitality.Classes.Concrete.Admin;
using Exam_Hospitality.DataBase;
using Exam_Hospitality.Json;

namespace Exam_Hospitality.Button;

class Button
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
                    SignIN.SignIn();
                    counter2 = Cursor.ShowSignInChoiceMenu();
                    Console.Clear();

                    switch (counter2)
                    {
                        case 0:
                            MainlyUsed.AddDoctor();
                            break;
                        case 1:
                            MainlyUsed.ShowDoctorFull();
                            break;
                        case 2:
                            MainlyUsed.EditDoctorData();
                            break;
                        case 3:
                            MainlyUsed.DeleteDoctor();
                            break;
                        case 4:
                            break;

                    }
                    Console.Clear();
                }

                else if (counter == 1)
                    admin = MainlyUsed.SignUpButton();
                else
                    break;
                counter = 0;
            }
            Console.CursorVisible = false;
        }
    }

    public static void Rezerv()
    {
        int success = 0;
        Console.Clear();
        VisualHelper.ShowWelcome();
        VisualHelper.ShowClinicName();
        Thread.Sleep(2000);

        DataBaseForDoctors dataBaseForDoctors = JsonSerialization.DeserializeDatabaseDoctor();


        Doctor currentDoctor;
        string doctorFullname, time;
        bool isReserved = false, hasFreeTime = false;

        while (true)
        {
            Console.Clear();

            currentDoctor = null!;

            if (success == 1)
                break;


            Pasient pasient = MainlyUsed.PasientSignIn();
            var choice = Cursor.ShowRezervMenu();

            List<Doctor> doctors = new();

            switch (choice)
            {
                case 0:
                    MainlyUsed.CheckDoctorSobe(dataBaseForDoctors, doctors, "Pediatrics");
                    break;
                case 1:
                    MainlyUsed.CheckDoctorSobe(dataBaseForDoctors, doctors, "Traumatology");
                    break;
                case 2:
                    MainlyUsed.CheckDoctorSobe(dataBaseForDoctors, doctors, "Dentistry");
                    break;
                case 3:
                    MainlyUsed.CheckDoctorSobe(dataBaseForDoctors, doctors, "Dietolog");
                    break;
                case 4:
                    MainlyUsed.CheckDoctorSobe(dataBaseForDoctors, doctors, "Psixiatr");
                    break;
                case 5:
                    MainlyUsed.CheckDoctorSobe(dataBaseForDoctors, doctors, "Rentgenolog");
                    break;
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
                            JsonSerialization.SerializeDatabaseDoctor(dataBaseForDoctors);
                            success = 1;

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

    public static void START()
    {
        while (true)
        {
            var location = Cursor.ShowStartMenu();
            if (location == 0)
                AdminButton();
            else
                Rezerv();
        }
    }
}
