using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _01_Collections;

public class Collections
{
    //Ersetze die /* */ mit den richtigen Antworten. Was ist der Wert von allCurrenciesList? Was ist der Wert von allCurrenciesSet? Wieso?

    internal class Program
    {
        private static HashSet<int> ListToHashSet(List<int> nums)
        {
            var hashSet = nums.ToHashSet();
            return hashSet;
        }

        public static void Main()
        {
            var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 6, 6, 7, 8, 2, 3, 1, 4 };
            var hashSet = ListToHashSet(nums);

            foreach (var num in hashSet)
            {
                Console.WriteLine(num);
            }

            var ExchangeRatesToChfByCurrency = MainTask();
            var usdRate = 1 / ExchangeRatesToChfByCurrency["USD"];
            var eurRate = 1 / ExchangeRatesToChfByCurrency["EUR"];

            Console.WriteLine("1 franc in USD is :" + Math.Round(usdRate, 2) + " USD$");
            Console.WriteLine("1 franc in EUR is :" + Math.Round(eurRate, 2) + " EUR€");

            CheckRate(ExchangeRatesToChfByCurrency);
        }

        //Schreibe eine Methode, die für jede übergebene Währung den Umrechnungskurs zurückgibt (mit dem vorher erstellten Dictionary). Falls die Währung nicht vorhanden ist, soll eine ArgumentException geworfen werden. (Tipp: Benutze dafür TryGetValue oder ContainsKey)
        public static void CheckRate(Dictionary<string, double> ExchangeRatesToChfByCurrency)
        {
            Console.WriteLine("write the currency in USD format to check the rate to Swiss Franc");
            var currency = Console.ReadLine();
            if (ExchangeRatesToChfByCurrency.ContainsKey(currency))
            {
                Console.WriteLine("your rate is: " + ExchangeRatesToChfByCurrency[currency]);
            }
        }

        public static Dictionary<string, double> MainTask()
        {
            var amount1 = new Money { Amount = 1.0m, Currency = "CHF" };
            var amount2 = new Money { Amount = 2.0m, Currency = "USD" };
            var amount3 = new Money { Amount = 1.6m, Currency = "EUR" };
            var amount4 = new Money { Amount = 3.2m, Currency = "CHF" };

            var allAmounts = new List<Money>() { amount1, amount2, amount3, amount4 };

            var allCurrenciesList = allAmounts.Select(d => d.Currency).ToList();

            var allCurrenciesSet = allCurrenciesList.ToHashSet();

            //Schreibe ein Dictionary, mit den Umrechnungskursen von Euro ("EUR") und US-Dollars ("USD") zu Schweizer Franken ("CHF"). Nenne diesen ExchangeRatesToChfByCurrency. Rufe diese mit einem Beispiel auf.
            Dictionary<string, double> ExchangeRatesToChfByCurrency =
                new Dictionary<string, double>();

            ExchangeRatesToChfByCurrency.Add("USD", 0.83);
            ExchangeRatesToChfByCurrency.Add("EUR", 0.95);

            return ExchangeRatesToChfByCurrency;
        }
    }

    internal class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
