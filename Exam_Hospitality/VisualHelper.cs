using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality
{
    public class VisualHelper
    {
        public static void Start()
        {
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
                            ██████╗   █████╗  ██╗  ██╗ ██╗ ██╗            ██████╗  ██╗     
                            ██╔══██╗ ██╔══██╗ ╚██╗██╔╝ ██║ ██║           ██╔═══██╗ ██║     
                            ██║  ██║ ███████║  ╚███╔╝  ██║ ██║           ██║   ██║ ██║     
                            ██║  ██║ ██╔══██║  ██╔██╗  ██║ ██║           ██║   ██║ ██║     
                            ██████╔╝ ██║  ██║ ██╔╝ ██╗ ██║ ███████╗      ╚██████╔╝ ███████╗
                            ╚═════╝  ╚═╝  ╚═╝ ╚═╝  ╚═╝ ╚═╝ ╚══════╝       ╚═════╝  ╚══════╝");
                Console.ResetColor();
            }
        }

        public static void ShowWelcome()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                    ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗
                    ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝
                    ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  
                    ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  
                    ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗
                     ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝
");
            Console.ResetColor();
        }
        public static void ShowClinicName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
     ██████╗ ██╗  ██╗███████╗██╗ ██████╗ ███████╗███╗   ██╗     ██████╗██╗     ██╗███╗   ██╗██╗ ██████╗
    ██╔═══██╗╚██╗██╔╝██╔════╝██║██╔════╝ ██╔════╝████╗  ██║    ██╔════╝██║     ██║████╗  ██║██║██╔════╝
    ██║   ██║ ╚███╔╝ ███████╗██║██║  ███╗█████╗  ██╔██╗ ██║    ██║     ██║     ██║██╔██╗ ██║██║██║     
    ██║   ██║ ██╔██╗ ╚════██║██║██║   ██║██╔══╝  ██║╚██╗██║    ██║     ██║     ██║██║╚██╗██║██║██║     
    ╚██████╔╝██╔╝ ██╗███████║██║╚██████╔╝███████╗██║ ╚████║    ╚██████╗███████╗██║██║ ╚████║██║╚██████╗
     ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝     ╚═════╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝ ╚═════╝");
            Console.ResetColor();

        }

        #region Choice

        public static void ShowAdminScript()
        {
            Console.WriteLine($@"
                                                ╔════════════╗
                                                ║   Admin    ║
                                                ╚════════════╝");
        }
        public static void ShowRezervScript()
        {
            Console.WriteLine($@"
                                                ╔════════════╗
                                                ║   Rezerv   ║
                                                ╚════════════╝");
        }

        #endregion



        public static void ShowAdmin()
        {
            Console.WriteLine(@"
                     █████╗ ██████╗ ███╗   ███╗██╗███╗   ██╗
                    ██╔══██╗██╔══██╗████╗ ████║██║████╗  ██║
                    ███████║██║  ██║██╔████╔██║██║██╔██╗ ██║
                    ██╔══██║██║  ██║██║╚██╔╝██║██║██║╚██╗██║
                    ██║  ██║██████╔╝██║ ╚═╝ ██║██║██║ ╚████║
                    ╚═╝  ╚═╝╚═════╝ ╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝                                      
");
        }

        #region Admin

        public static void ShowSignInScript()
        {
            //   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
                                                ╔═══════════╗
                                                ║  Sign In  ║
                                                ╚═══════════╝");
            //    Console.ResetColor();
        }
        public static void ShowSignUpScript()
        {
            //   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
                                                ╔═══════════╗
                                                ║  Sign Up  ║
                                                ╚═══════════╝");
            //   Console.ResetColor();
        }
        public static void ShowBackScript()
        {
            //   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
                                                ╔═══════════╗
                                                ║   BACK    ║
                                                ╚═══════════╝
");
            //   Console.ResetColor();
        }

        #endregion

        #region SignUp && Sign In

        public static void ShowSignUpHeadline()
        {
            Console.WriteLine(@"  
                                         ███████╗██╗ ██████╗ ███╗   ██╗    ██╗   ██╗██████╗ 
                                        ██╔════╝██║██╔════╝ ████╗  ██║    ██║   ██║██╔══██╗
                                        ███████╗██║██║  ███╗██╔██╗ ██║    ██║   ██║██████╔╝
                                        ╚════██║██║██║   ██║██║╚██╗██║    ██║   ██║██╔═══╝ 
                                        ███████║██║╚██████╔╝██║ ╚████║    ╚██████╔╝██║     
                                        ╚══════╝╚═╝ ╚═════╝ ╚═╝  ╚═══╝     ╚═════╝ ╚═╝     ");
            Console.ResetColor();

        }
        public static void ShowSignInHeadline()
        {
            Console.WriteLine(@" 
                                        ███████╗██╗ ██████╗ ███╗   ██╗    ██╗ ███╗   ██╗
                                        ██╔════╝██║██╔════╝ ████╗  ██║    ██║ ████╗  ██║
                                        ███████╗██║██║  ███╗██╔██╗ ██║    ██║ ██╔██╗ ██║
                                        ╚════██║██║██║   ██║██║╚██╗██║    ██║ ██║╚██╗██║
                                        ███████║██║╚██████╔╝██║ ╚████║    ██║ ██║ ╚████║
                                        ╚══════╝╚═╝ ╚═════╝ ╚═╝  ╚═══╝    ╚═╝ ╚═╝  ╚═══╝
");
            Console.ResetColor();
        }

        #endregion


    }
}
