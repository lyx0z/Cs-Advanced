namespace _02.Enums;

class Program
{
    public static void Main()
    {
        Person.Greeting();
    }
}

internal class Person
{
    //Erstelle ein Enum "Gender" mit den Werten "Male", "Female" und "Unknown". Erstelle eine Klasse Person mit den Attributen Namen, Alter und dem zuvor implementierten Geschlecht.
    private string? Name;
    private int Age;

    private enum Gender
    {
        Male,
        Female,
        Unknown,
    }

    public static void Greeting()
    {
        var activeUser = new Person();

        Console.WriteLine("Whats Your Name?");
        activeUser.Name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        int.TryParse(Console.ReadLine(), out activeUser.Age);

        Console.WriteLine("Whats your gender? Options: Female, Male, Unknown");
        var gender = Console.ReadLine();
        Gender genderEnum;
        switch (gender)
        {
            case "Male":
                genderEnum = Gender.Male;
                break;
            case "Female":
                genderEnum = Gender.Female;
                break;
            case "Unknown":
                genderEnum = Gender.Unknown;
                break;
            default:
                genderEnum = Gender.Unknown;
                Console.WriteLine("Saved as unknown. You may try again");
                break;
        }

        Console.WriteLine(
            $"Saved Data is - Name: {activeUser.Name}, Age: {activeUser.Age}, Gender: {genderEnum}"
        );
        if (genderEnum == Gender.Female)
        {
            Console.WriteLine($"Hallo Frau {activeUser.Name}");
        }
        else if (genderEnum == Gender.Male)
        {
            Console.WriteLine($"Hallo Herr {activeUser.Name}");
        }
        else
        {
            Console.WriteLine($"Hallo Herr*Frau {activeUser.Name}");
        }
    }
}
