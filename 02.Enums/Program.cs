namespace _02.Enums;

public enum Gender
{
    Male,
    Female,
    Unknown,
}

public class Program
{
    public static void Main()
    {
        var nameAndGender = Person.GetGreeting(new Person("Nikita", 17, Gender.Male));
        Console.WriteLine($"Hallo {nameAndGender.Item2} {nameAndGender.Item1}");
    }
}

internal class Person(string name, int age, Gender gender)
{
    private string name = name;
    private readonly int age = age;
    private readonly Gender gender = gender;

    public static (string, string) GetGreeting(Person activeUser)
    {
        switch (activeUser.gender)
        {
            case Gender.Female:
                return (activeUser.name, "Frau");
            case Gender.Male:
                return (activeUser.name, "Herr");
            default:
                return (activeUser.name, "Herr*Frau");
        }
    }
}
