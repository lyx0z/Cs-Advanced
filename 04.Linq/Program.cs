namespace _04.Linq;

public class Program
{
    public static void Main()
    {
        var numList = new List<int>()
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
        };

        foreach (var num in numList)
        {
            Console.WriteLine(num);
        }
    }
}
