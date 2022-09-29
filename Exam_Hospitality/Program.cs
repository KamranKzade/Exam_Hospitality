using Exam_Hospitality.Classes;
using Exam_Hospitality.Classes.Concrete;

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
                Console.Clear();
                VisualHelper.ShowWelcome();
                VisualHelper.ShowClinicName();
                Thread.Sleep(2000);

                //// Elave olunmalidir.....   3 hekim 
                List<Doctor> pediatricsDoctors, traumatologyDoctors, dentistryDoctors;
                MainlyUsed.Data(out pediatricsDoctors, out traumatologyDoctors, out dentistryDoctors);

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



                    var command = Cursor.ShowRezervMenu();




                    List<Doctor> doctors = null!;

                    switch (command)
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

                        //// burda qalmisam

                        //// 3 , 4 , 5 deyerine gore hekimler doldurulub yazilmalidir


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
    }
}