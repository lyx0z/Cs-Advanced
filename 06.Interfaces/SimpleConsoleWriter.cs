namespace _06.Interfaces;

public class SimpleConsoleWriter : ITextWriter
{
    public void Print(string text) => Console.Write(text);

    public void PrintLine(string text) => Console.WriteLine(text);

    public void PrintLine() => Console.WriteLine();
}
