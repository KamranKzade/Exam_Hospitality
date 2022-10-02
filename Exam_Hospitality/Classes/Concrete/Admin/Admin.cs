using Exam_Hospitality.Classes.Abstract;


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

    public override string ToString()
=> @$"
Username: {UserName}
Passwrod: {Password}
{base.ToString()}
";
}