namespace _06.Interfaces;

public class RandomTextWriter(ITextWriter textWriter)
{
    private readonly ITextWriter textWriter = textWriter;

    public void SomeNumbers()
    {
        var random = new Random();
        for (var row = 0; row < 10; row++)
        {
            for (var col = 0; col < 10; col++)
            {
                var number = random.Next(1, 100);
                textWriter.Print(number + " "); 
            }
            textWriter.NewLine(); 
        }
    }
}
