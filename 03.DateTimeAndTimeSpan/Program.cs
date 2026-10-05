namespace _03.DateTimeAndTimeSpan;

public class Program
{
    public static void Main()
    {
        var invoice = new Invoice();
        var cetTime = new DateTime(2021, 10, 20, 10, 50, 20);
        invoice.IsDeadLinePastDue();
        Console.WriteLine(invoice.IsDeadLinePastDue() ? "past deadline" : "not past deadline");

        var birthday = new DateTime(2009, 09, 18);
        Birthdate.DaysSinceBirthday(birthday);

        var utcTime = TimezoneConvert.ConvertCetToUtc(cetTime);
        Console.WriteLine(utcTime);
    }
}

//Eine Rechnung hat einen Schuldner, einen Betrag und ein Fälligkeitsdatum. Schreibe eine Methode, die überprüft, ob eine Rechnung ihr Fälligkeitsdatum überschritten hat und rufe diese mit drei Beispielen auf. (Ev. als Unit-Test)
public class Invoice
{
    public string debtor = "notNikita";
    public int debt = 62848;
    public DateTime dueDate;

    public bool IsDeadLinePastDue()
    {
        return DateTime.Today > dueDate;
    }
}

//Schreibe eine Methode, wo du für ein bestimmtes Datum herausfinden kannst, wie viele Tage seither vergangen sind. Wie alt bist du in Tagen?
public static class Birthdate
{
    public static void DaysSinceBirthday(DateTime birthday)
    {
        var daysSince = DateTime.Today - birthday;
        Console.WriteLine(daysSince);
    }
}

//Schreibe eine Methode, die eine bestimmte Uhrzeit von 2021 von CET (CET ) nach UTC (Koordinierte Weltzeit ) umwandelt. Beachte dabei den Unterschied von Winter- und Sommerzeit!
public static class TimezoneConvert
{
    public static DateTime ConvertCetToUtc(DateTime time)
    {
        var cet = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
        return TimeZoneInfo.ConvertTimeToUtc(time, cet);
    }
}
