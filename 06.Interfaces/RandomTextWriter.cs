namespace _06.Interfaces;

public class RandomTextWriter(ITextWriter textWriter)
{
    private readonly ITextWriter TextWriter = textWriter;

    public void SomeNumbers()
    {
        var random = new Random();
        for (var row = 0; row < 10; row++)
        {
            for (var col = 0; col < 10; col++)
            {
                var number = random.Next(1, 100);
                TextWriter.Print(number + " "); 
            }
            TextWriter.PrintLine(); 
        }
    }
}
