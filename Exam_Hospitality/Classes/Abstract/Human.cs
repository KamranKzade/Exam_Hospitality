namespace Exam_Hospitality.Classes.Abstract;


abstract public class Human
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public byte Age { get; set; }
    public string? City { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }


    public Human()
    {

    }
     public Human(string? name, string? surname, byte age, string? city, string? email, string? phone)
    {
        Name = name;
        Surname = surname;
        Age = age;
        City = city;
        Email = email;
        Phone = phone;
    }

    public override string ToString()
    => @$"Name: {Name}
Surname: {Surname}
Age: {Age}
City: {City}
Email: {Email}
Phone: {Phone}";

}

