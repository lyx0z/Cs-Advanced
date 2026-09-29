using System.Globalization;

namespace _02.Enums;

public enum Gender
{
    Male,
    Female,
    Unknown,
}

class Program
{
    public static void Main()
    {
        Person.GetGreeting(new Person("Nikita", 17, Gender.Male));
    }
}

internal class Person
{
    public Person(string name, int age, Gender gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    private string name;
    private readonly int age;
    private readonly Gender gender;

    public static void GetGreeting(Person activeUser)
    {
        switch (activeUser.gender)
        {
            case Gender.Female:
                Console.WriteLine($"Hallo Frau {activeUser.name}");
                break;
            case Gender.Male:
                Console.WriteLine($"Hallo Herr {activeUser.name}");
                break;
            default:
                Console.WriteLine($"Hallo Herr*Frau {activeUser.name}");
                break;
        }
    }
}
