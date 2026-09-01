namespace _01_Collections;

public class Collections
{
    public static void Main()
    {
        var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 6, 6, 7, 8, 2, 3, 1, 4 };
        var hashSet = ListToHashSet(nums);

        foreach (var num in hashSet)
        {
            Console.WriteLine(num);
        }
    }

    private static HashSet<int> ListToHashSet(List<int> nums)
    {
        var hashSet = nums.ToHashSet();
        return hashSet;
    }
}
