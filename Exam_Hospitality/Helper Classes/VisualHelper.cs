﻿namespace Exam_Hospitality;

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

    #region +Welcome

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

    #endregion

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


    public static void EnterDataDoctor()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
╔═╗ ┌┐┌┌┬┐┌─┐┬─┐  ┌┬┐┌─┐┌┬┐┌─┐                         
║╣  │││ │ ├┤ ├┬┘   ││├─┤ │ ├─┤                         
╚═╝ ┘└┘ ┴ └─┘┴└─  ─┴┘┴ ┴ ┴ ┴ ┴           
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

    #region +Bolmeler


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

    #region +Doctor

    public static void ShowDoctorScript()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
                    $$$$$$$\                        $$\                         
                    $$  __$$\                       $$ |                        
                    $$ |  $$ | $$$$$$\   $$$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  
                    $$ |  $$ |$$  __$$\ $$  _____|\_$$  _|  $$  __$$\ $$  __$$\ 
                    $$ |  $$ |$$ /  $$ |$$ /        $$ |    $$ /  $$ |$$ |  \__|
                    $$ |  $$ |$$ |  $$ |$$ |        $$ |$$\ $$ |  $$ |$$ |      
                    $$$$$$$  |\$$$$$$  |\$$$$$$$\   \$$$$  |\$$$$$$  |$$ |      
                    \_______/  \______/  \_______|   \____/  \______/ \__|      
                                                       ");
        Console.ResetColor();
    }

    public static void ShowDoctorInfoScript()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
                    ██████╗  ██████╗  ██████╗████████╗ ██████╗ ██████╗     ██╗███╗   ██╗███████╗ ██████╗ 
                    ██╔══██╗██╔═══██╗██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗    ██║████╗  ██║██╔════╝██╔═══██╗
                    ██║  ██║██║   ██║██║        ██║   ██║   ██║██████╔╝    ██║██╔██╗ ██║█████╗  ██║   ██║
                    ██║  ██║██║   ██║██║        ██║   ██║   ██║██╔══██╗    ██║██║╚██╗██║██╔══╝  ██║   ██║
                    ██████╔╝╚██████╔╝╚██████╗   ██║   ╚██████╔╝██║  ██║    ██║██║ ╚████║██║     ╚██████╔╝
                    ╚═════╝  ╚═════╝  ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝    ╚═╝╚═╝  ╚═══╝╚═╝      ╚═════╝ ");
        Console.ResetColor();
    }

    #endregion

    #region +Reception


    public static void ShowRecptionScript()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
            ┬─┐┌─┐┌─┐┌─┐┌─┐┌┬┐┬┌─┐┌┐┌  ┌┬┐┬┌┬┐┌─┐
            ├┬┘├┤ │  ├┤ ├─┘ │ ││ ││││   │ ││││├┤ 
            ┴└─└─┘└─┘└─┘┴   ┴ ┴└─┘┘└┘   ┴ ┴┴ ┴└─┘");
        Console.ResetColor();
    }

    public static void ShowSuccesfully()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
.--.                                   .                                 .-.     . .     
|   )                                  |                                 |       | |     
|--'  .-. .--. .-. .--..    ._ .-.  .-.|      .--..  .  .-. .-. .-. .--.-|- .  . | | .  .
|  \ (.-' `--.(.-' |    \  /  (.-' (   |      `--.|  | (   (   (.-' `--. |  |  | | | |  |
'   ` `--'`--' `--''     `'    `--' `-'`-     `--'`--`- `-' `-' `--'`--' '  `--`-`-`-`--|
                                                                                        ;
                                                                                     `-' ");
        Console.ResetColor();
    }


    #endregion

    #region SignInChoice

    public static void ShowAddDoctorScript()
    {
        Console.WriteLine($@"                  
                                                ╔══════════════════╗
                                                ║    Add Doctor    ║
                                                ╚══════════════════╝");
    }
    public static void ShowDoctorAllScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║  Show Doctor All ║
                                                ╚══════════════════╝");
    }


    public static void EditDoctorScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║    Edit Doctor   ║
                                                ╚══════════════════╝");
    }


    public static void DeleteDoctorScript()
    {
        Console.WriteLine($@"                   
                                                ╔══════════════════╗
                                                ║   Delete Doctor  ║
                                                ╚══════════════════╝");
    }

    public static void ShowBackAdminScript()
    {
        Console.WriteLine($@"
                                                ╔══════════════════╗
                                                ║       BACK       ║
                                                ╚══════════════════╝
");
    }

    public static void ChoiceScript()
    {
        Console.WriteLine(@" 
                                    ██████╗██╗  ██╗ ██████╗ ██╗ ██████╗███████╗
                                    ██╔════╝██║  ██║██╔═══██╗██║██╔════╝██╔════╝
                                    ██║     ███████║██║   ██║██║██║     █████╗  
                                    ██║     ██╔══██║██║   ██║██║██║     ██╔══╝  
                                    ╚██████╗██║  ██║╚██████╔╝██║╚██████╗███████╗
                                     ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝ ╚═════╝╚══════╝");
    }


    #endregion

    #region +Successfully


    public static void ShowSuccessfullyAdded()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
                    ╔╦╗┌─┐┌─┐┌┬┐┌─┐┬─┐   ╔═╗┬ ┬┌─┐┌─┐┌─┐┌─┐┌─┐┬ ┬┬  ┬  ┬ ┬    ┌─┐┌┬┐┌┬┐┌─┐┌┬┐
                     ║║│ ││   │ │ │├┬┘   ╚═╗│ ││  │  ├┤ └─┐├┤ │ ││  │  └┬┘    ├─┤ ││ ││├┤  ││
                    ═╩╝└─┘└─┘ ┴ └─┘┴└─   ╚═╝└─┘└─┘└─┘└─┘└─┘└  └─┘┴─┘┴─┘ ┴     ┴ ┴─┴┘─┴┘└─┘─┴┘");
        Console.ResetColor();
    }

    public static void ShowSuccessfullyDeleted()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
___ _  _ ____    ___  ____ ____ ___ ____ ____    _ _ _ ____ ____    ____ _  _ ____ ____ ____ ____ ____ ____ _  _ _    _    _   _    ___  ____ _    ____ ___ ____ ___  
 |  |__| |___    |  \ |  | |     |  |  | |__/    | | | |__| [__     [__  |  | |    |    |___ [__  [__  |___ |  | |    |     \_/     |  \ |___ |    |___  |  |___ |  \ 
 |  |  | |___    |__/ |__| |___  |  |__| |  \    |_|_| |  | ___]    ___] |__| |___ |___ |___ ___] ___] |    |__| |___ |___   |      |__/ |___ |___ |___  |  |___ |__/ 
   ");
        Console.ResetColor();
    }

    #endregion

    #region +ProfessionScript

    public static void ShowProfessionScript()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"                             ___   ___   ___   ____  ____  __   __   _   ___   _     
                            | |_) | |_) / / \ | |_  | |_  ( (` ( (` | | / / \ | |\ | 
                            |_|   |_| \ \_\_/ |_|   |_|__ _)_) _)_) |_| \_\_/ |_| \|");
        Console.ResetColor();
    }

    #endregion
}