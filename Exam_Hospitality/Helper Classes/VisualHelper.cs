using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality;

public class VisualHelper
{
    #region +Giris

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

    #endregion


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

    #region Rezerv

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

    #endregion


    #region +EnterData

    public static void EnterData()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
╔═╗ ┌┐┌┌┬┐┌─┐┬─┐  ┬ ┬┌─┐┬ ┬┬─┐  ┌┬┐┌─┐┌┬┐┌─┐                         
║╣  │││ │ ├┤ ├┬┘  └┬┘│ ││ │├┬┘   ││├─┤ │ ├─┤                         
╚═╝ ┘└┘ ┴ └─┘┴└─   ┴ └─┘└─┘┴└─  ─┴┘┴ ┴ ┴ ┴ ┴                         
                                                ╔═╗┬  ┌─┐┌─┐┌─┐┌─┐  
                                                ╠═╝│  ├┤ ├─┤└─┐├┤   
                                                ╩  ┴─┘└─┘┴ ┴└─┘└─┘  ");

        Console.ResetColor();
    
    }
    #endregion

    #region +NeedLabel

    public static void NeedLabel()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"╦ ╦┬ ┬┬┌─┐┬ ┬  ┌─┐┌─┐┌─┐┌─┐┬┌─┐┬  ┬┌─┐┌┬┐  ┌┬┐┌─┐  ┬ ┬┌─┐┬ ┬  ┌┐┌┌─┐┌─┐┌┬┐┌─┐
║║║├─┤││  ├─┤  └─┐├─┘├┤ │  │├─┤│  │└─┐ │    │││ │  └┬┘│ ││ │  │││├┤ ├┤  ││ ┌┘
╚╩╝┴ ┴┴└─┘┴ ┴  └─┘┴  └─┘└─┘┴┴ ┴┴─┘┴└─┘ ┴   ─┴┘└─┘   ┴ └─┘└─┘  ┘└┘└─┘└─┘─┴┘ o ");
        Console.ResetColor();
    }

    #endregion



    #region Bolmeler


    public static void ShowPediatricsScript()
    {
        Console.WriteLine($@"                  
                                                ╔══════════════════╗
                                                ║    Pediatrics    ║
                                                ╚══════════════════╝");
    }
    public static void ShowTraumotologyScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║   Traumotology   ║
                                                ╚══════════════════╝");
    }


    public static void ShowDentistryScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║     Dentistry    ║
                                                ╚══════════════════╝");
    }


    public static void ShowDietologScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║     Dietolog     ║
                                                ╚══════════════════╝");
    }

    public static void ShowPsixiatrScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║     Psixiatr     ║
                                                ╚══════════════════╝");
    }



    public static void ShowRentgenologScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║    Rentgenolog   ║
                                                ╚══════════════════╝");
    }

    #endregion

    #region +Choice

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


    #region +AdminClick

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

    #endregion

    #region +Admin

    public static void ShowSignInScript()
    {
        Console.WriteLine($@"
                                                ╔═══════════╗
                                                ║  Sign In  ║
                                                ╚═══════════╝");
    }
    public static void ShowSignUpScript()
    {
        Console.WriteLine($@"
                                                ╔═══════════╗
                                                ║  Sign Up  ║
                                                ╚═══════════╝");
    }
    public static void ShowBackScript()
    {
        Console.WriteLine($@"
                                                ╔═══════════╗
                                                ║   BACK    ║
                                                ╚═══════════╝
");
    }

    #endregion

    #region +SignUp && Sign In

    public static void ShowSignUpHeadline()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
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
        Console.ForegroundColor = ConsoleColor.Cyan;
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

    #region +Qeydiyyat

    public static void ShowQeydiyyatdanKecdiz()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
██████╗ ███████╗██╗   ██╗██████╗ ██╗██╗   ██╗██╗   ██╗ █████╗ ████████╗    ██╗  ██╗███████╗ ██████╗██████╗ ██╗███████╗
██╔═══██╗██╔════╝╚██╗ ██╔╝██╔══██╗██║╚██╗ ██╔╝╚██╗ ██╔╝██╔══██╗╚══██╔══╝    ██║ ██╔╝██╔════╝██╔════╝██╔══██╗██║╚══███╔╝
██║   ██║█████╗   ╚████╔╝ ██║  ██║██║ ╚████╔╝  ╚████╔╝ ███████║   ██║       █████╔╝ █████╗  ██║     ██║  ██║██║  ███╔╝ 
██║▄▄ ██║██╔══╝    ╚██╔╝  ██║  ██║██║  ╚██╔╝    ╚██╔╝  ██╔══██║   ██║       ██╔═██╗ ██╔══╝  ██║     ██║  ██║██║ ███╔╝  
╚██████╔╝███████╗   ██║   ██████╔╝██║   ██║      ██║   ██║  ██║   ██║       ██║  ██╗███████╗╚██████╗██████╔╝██║███████╗
 ╚══▀▀═╝ ╚══════╝   ╚═╝   ╚═════╝ ╚═╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝   ╚═╝       ╚═╝  ╚═╝╚══════╝ ╚═════╝╚═════╝ ╚═╝╚══════╝");

        Thread.Sleep(3000);
    }

    #endregion


}
