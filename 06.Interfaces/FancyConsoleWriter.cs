namespace _06.Interfaces;

public class FancyConsoleWriter : ITextWriter
{
    private readonly Random random = new();
    
    public void Print(string text)
    {
        
        foreach (var character in text)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            Console.Write(character);
        }
        Console.ResetColor();
    }

    public void PrintLine(string text)
    {
        Print(text);
        PrintLine();
    }

    public void PrintLine()
    {
        Console.WriteLine();
    }
}