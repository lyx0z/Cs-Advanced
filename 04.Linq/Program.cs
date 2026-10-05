namespace _04.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numList = Enumerable.Range(1, 20).ToList();

        //Selektiere aus einer Liste mit allen Zahlen von 1 - 20 nur diese, welche durch drei teilbar sind
        var result = numList.Where(x => x % 3 == 0);
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }

        //Zähle die Summe aus dem Ergebnis von 1.
        var sum = result.Sum();
        Console.WriteLine(sum);

        //Erstelle eine Liste mit mindestens fünf Personen (Name und Geschlecht).
        //Wähle mit Linq alle männlichen Personen aus und sortiere diese nach Namen.

        var people = new List<Person>()
        {
            new("Max", Gender.Male),
            new("David", Gender.Male),
            new("Johnny", Gender.Male),
            new("Kate", Gender.Female),
            new("Rebecca", Gender.Female),
            new("Lucy", Gender.Female)
        };

        var onlyMale = people
            .Where(person => person.Gender == Gender.Male)
            .OrderBy(person => person.Name);
        foreach (var person in onlyMale)
        {
            Console.WriteLine(person.Name);
        }
    
        //Überprüfe ob es mindestens eine weibliche Person in der Liste gibt.
        var areAnyFemales = people.Any(females => females.Gender == Gender.Female);
        
        var resultFemales = areAnyFemales ? "There are females" : "there are no females";
        Console.WriteLine(resultFemales);
        
        //Erstelle mit .Select eine Liste mit allen Namen der Personen.
        var query = people.Select(person => person.Name);
        foreach (var name in query)
        {
            Console.WriteLine(name);
        }
        
        //Gruppiere die Personen nach Geschlecht.
        //Gebe anschliessend die Anzahl der Personen des jeweiligen Geschlecht aus.
        
        var groupByGender = people.GroupBy(
            person => person.Gender,
            (gender, persons) => new {Gender = gender, Count = persons.Count()}
        );

        foreach (var group in groupByGender)
        {
            Console.WriteLine(group.Gender + ":" + group.Count);
        }
    }
}

public enum Gender
{
    Male,
    Female
}

public record Person(string Name, Gender Gender);
