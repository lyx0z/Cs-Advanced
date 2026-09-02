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

    //Ersetze die /* */ mit den richtigen Antworten. Was ist der Wert von allCurrenciesList? Was ist der Wert von allCurrenciesSet? Wieso?
    internal class Program
    {
        public static void Task()
        {
            var amount1 = new Money { Amount = 1.0m, Currency = "CHF" };
            var amount2 = new Money { Amount = 2.0m, Currency = "USD" };
            var amount3 = new Money { Amount = 1.6m, Currency = "EUR" };
            var amount4 = new Money { Amount = 3.2m, Currency = "CHF" };
            var allAmounts = new List<Money>() { amount1, amount2, amount3, amount4 };
            var allCurrenciesList = allAmounts.Select(d => d.Currency).ToList();
            var allCurrenciesSet = allCurrenciesList.ToHashSet();
        }
    }

    internal class Money
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
    }
}
