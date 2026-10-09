namespace _07.ValueVsReferenceTypes;

internal class Student
{
    public string Name;
}

public static class Program
{
    private static void ChangeAge(int age)
    {
        age = 20;
    }

    private static void ChangeName(Student student)
    {
        student.Name = "Alex";
    }

    public static void Main()
    {
        const int age = 16;
        var student = new Student();
        student.Name = "Nick";

        ChangeAge(age);
        ChangeName(student);

        Console.WriteLine(age);           // 16
        Console.WriteLine(student.Name);  // Alex
    }
}