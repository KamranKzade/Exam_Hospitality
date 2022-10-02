using Exam_Hospitality.Classes.Concrete.Admin;

namespace Exam_Hospitality;



class Cursor
{
    public static int ShowStartMenu()
    {
        int counter = 0;
        const int size = 2;
        ConsoleColor[] Set = new ConsoleColor[size] { ConsoleColor.Yellow, ConsoleColor.Yellow };
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


            VisualHelper.Start();
            Console.ForegroundColor = Set[0];
            VisualHelper.ShowAdminScript();
            Console.ForegroundColor = Set[1];
            VisualHelper.ShowRezervScript();
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
                    return 0;
                else
                    return 1;
            }
            Console.CursorVisible = false;
        }
    }

    public static int ShowRezervMenu()
    {
        int counter = 0;
        const int size = 6;
        ConsoleColor[] Set = new ConsoleColor[size] { ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow };
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


            VisualHelper.NeedLabel();
            Console.ForegroundColor = Set[0];
            VisualHelper.ShowPediatricsScript();
            Console.ForegroundColor = Set[1];
            VisualHelper.ShowTraumotologyScript();
            Console.ForegroundColor = Set[2];
            VisualHelper.ShowDentistryScript();
            Console.ForegroundColor = Set[3];
            VisualHelper.ShowDietologScript();
            Console.ForegroundColor = Set[4];
            VisualHelper.ShowPsixiatrScript();
            Console.ForegroundColor = Set[5];
            VisualHelper.ShowRentgenologScript();


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
                    return 0;
                else if (counter == 1)
                    return 1;
                else if (counter == 2)
                    return 2;
                else if (counter == 3)
                    return 3;
                else if (counter == 4)
                    return 4;
                else if (counter == 5)
                    return 5;

            }
            Console.CursorVisible = false;
        }
    }

    public static int ShowProfessionMenu()
    {
        int counter = 0;
        const int size = 6;
        ConsoleColor[] Set = new ConsoleColor[size] { ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow };
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


            VisualHelper.ShowProfessionScript();
            Console.ForegroundColor = Set[0];
            VisualHelper.ShowPediatricsScript();
            Console.ForegroundColor = Set[1];
            VisualHelper.ShowTraumotologyScript();
            Console.ForegroundColor = Set[2];
            VisualHelper.ShowDentistryScript();
            Console.ForegroundColor = Set[3];
            VisualHelper.ShowDietologScript();
            Console.ForegroundColor = Set[4];
            VisualHelper.ShowPsixiatrScript();
            Console.ForegroundColor = Set[5];
            VisualHelper.ShowRentgenologScript();


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
                    return 0;
                else if (counter == 1)
                    return 1;
                else if (counter == 2)
                    return 2;
                else if (counter == 3)
                    return 3;
                else if (counter == 4)
                    return 4;
                else if (counter == 5)
                    return 5;

            }
            Console.CursorVisible = false;
        }
    }

    public static int ShowSignInChoiceMenu()
    {
        int counter = 0;
        const int size = 5;
        ConsoleColor[] Set = new ConsoleColor[size] { ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Yellow };
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
            VisualHelper.ChoiceScript();
            Console.ForegroundColor = Set[0];
            VisualHelper.ShowAddDoctorScript();
            Console.ForegroundColor = Set[1];
            VisualHelper.ShowDoctorAllScript();
            Console.ForegroundColor = Set[2];
            VisualHelper.EditDoctorScript();
            Console.ForegroundColor = Set[3];
            VisualHelper.DeleteDoctorScript();
            Console.ForegroundColor = Set[4];
            VisualHelper.ShowBackAdminScript();

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
                    return 0;
                else if (counter == 1)
                    return 1;
                else if (counter == 2)
                    return 2;
                else if (counter == 3)
                    return 3;
                else if (counter == 4)
                    return 4;
            }
            Console.CursorVisible = false;
        }
    }


}