using Exam_Hospitality.Classes.Concrete.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality
{

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
   



    }
}
