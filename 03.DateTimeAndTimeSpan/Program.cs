using System.Runtime.InteropServices.JavaScript;

namespace _03.DateTimeAndTimeSpan;

public class Program
{
    public static void Main()
    {
        var cetTime = new DateTime(2021, 10, 20, 10, 50, 20);
        var dueTime = new DateTime(2026, 10, 20);
        Invoice.IsDeadLinePastDue(dueTime);
        Console.WriteLine(
            Invoice.IsDeadLinePastDue(dueTime) ? "past deadline" : "not past deadline"
        );

        Birthdate.DaysSinceBirthday();
        var utcTime = TimezoneConvert.ConvertCetToUtc(cetTime);
        Console.WriteLine(utcTime);
    }
}

//Eine Rechnung hat einen Schuldner, einen Betrag und ein Fälligkeitsdatum. Schreibe eine Methode, die überprüft, ob eine Rechnung ihr Fälligkeitsdatum überschritten hat und rufe diese mit drei Beispielen auf. (Ev. als Unit-Test)
public class Invoice
{
    public string debtor = "notNikita";
    public int debt = 62848;
    public DateTime dueTime;

    public static bool IsDeadLinePastDue(DateTime dueTime)
    {
        return DateTime.Today > dueTime;
    }
}

//Schreibe eine Methode, wo du für ein bestimmtes Datum herausfinden kannst, wie viele Tage seither vergangen sind. Wie alt bist du in Tagen?
public static class Birthdate
{
    public static void DaysSinceBirthday()
    {
        var birthday = new DateTime(2009, 09, 18);
        var daysSince = DateTime.Today - birthday;
        Console.WriteLine(daysSince);
    }
}

//Schreibe eine Methode, die eine bestimmte Uhrzeit von 2021 von CET (CET ) nach UTC (Koordinierte Weltzeit ) umwandelt. Beachte dabei den Unterschied von Winter- und Sommerzeit!
public static class TimezoneConvert
{
    static TimeSpan cetOffset = TimeSpan.FromHours(1);
    static TimeZoneInfo cetTimeZone = TimeZoneInfo.CreateCustomTimeZone(
        "CET",
        cetOffset,
        "Central European Time (CET)",
        "CET"
    );

    public static DateTime ConvertCetToUtc(DateTime time)
    {
        return TimeZoneInfo.ConvertTimeToUtc(time, cetTimeZone);
    }
}
