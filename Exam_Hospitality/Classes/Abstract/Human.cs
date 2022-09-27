namespace Exam_Hospitality.Classes.Abstract;


abstract class Human
{
    private string? _name;
    public string? Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                throw new ArgumentException("Enter Name, again");
            _name = value;
        }
    }



    private string? _surname;
    public string? Surname
    {
        get { return _surname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                throw new ArgumentException("Enter Surname, again");

            _surname = value;
        }
    }




    private byte _age;
    public byte Age
    {
        get { return _age; }

        set
        {
            if (value < 0)
                throw new IndexOutOfRangeException("Enter age, again");
            _age = value;
        }
    }


    private string? _city;
    public string? City
    {
        get { return _city; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                throw new ArgumentException("Enter City, again");
            _city = value;
        }
    }

    private string? _email;
    public string? Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 7)
                throw new ArgumentException("Enter Email, again");
            if (!value.EndsWith("@gmail.com") || !value.EndsWith("@mail.ru"))
                _email = value;
        }
    }


    private string? _phone;
    public string? Phone
    {
        get { return _phone; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                throw new ArgumentException("Enter Phone number, again");
            if (!value.All(char.IsDigit))
                _phone = value;
        }
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

