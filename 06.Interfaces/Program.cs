namespace _06.Interfaces;

public static class Program
{
    public static void Main()
    {
        var simpleConsoleWriter = new SimpleConsoleWriter();
        var fancyConsoleWriter = new FancyConsoleWriter();
        ITextWriter fileWriter = new FileTextWriter();
        
        var randomWriter = new RandomTextWriter(fileWriter);
        var simpleRandomTextWriter = new RandomTextWriter(simpleConsoleWriter);
        simpleRandomTextWriter.SomeNumbers();
        
        Console.WriteLine("___________________");
        
        var fancyRandomTextWriter = new RandomTextWriter(fancyConsoleWriter);
        fancyRandomTextWriter.SomeNumbers();
        randomWriter.SomeNumbers();
    }
}
