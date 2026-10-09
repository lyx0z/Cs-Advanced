namespace _06.Interfaces
{
    public class FileTextWriter : ITextWriter
    {
        private const string filePath = "numbers_output.txt";

        public void Print(string text)
        { 
            File.AppendAllText(filePath, text);
        }

        public void PrintLine(string text)
        {
            File.AppendAllText(filePath, text + Environment.NewLine);
        }

        public void NewLine()
        {
            File.AppendAllText(filePath, Environment.NewLine);
        }
        
    }
}