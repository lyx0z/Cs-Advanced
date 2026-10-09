namespace _06.Interfaces
{
    public class FileTextWriter : ITextWriter
    {
        private readonly string FilePath = "numbers_output.txt";

        public void Print(string text)
        { 
            File.AppendAllText(FilePath, text);
        }

        public void PrintLine(string text)
        {
            File.AppendAllText(FilePath, text + Environment.NewLine);
        }

        public void PrintLine()
        {
            File.AppendAllText(FilePath, Environment.NewLine);
        }
        
    }
}