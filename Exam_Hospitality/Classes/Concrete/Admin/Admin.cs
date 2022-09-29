using Exam_Hospitality.Classes.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Hospitality.Classes.Concrete.Admin;

public class Admin : Human
{
    public string? UserName { get; set; }
    public string? Password { get; set; }




    public Admin() : base()
    {

    }

    public Admin(string? name, string? surname, byte age, string? city, string? email, string? phone, string? username, string? password)
        : base(name, surname, age, city, email, phone)
    {
        UserName = username;
        Password = password;
    }





    





    public  (string username, string password) SignIn()
    {
        while (true)
        {
            Console.Write("\n ENTER YOUR USERNAME : ");
            string username = Console.ReadLine()!.Trim();

            Console.Write("\n ENTER YOUR PASSWORD : ");
            string password = Console.ReadLine()!.Trim();


            return (username, password);
        }
    }

    public override string ToString()
=> @$"
Username: {UserName}
Passwrod: {Password}
{base.ToString()}
";

}
