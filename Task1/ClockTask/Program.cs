using System;
using System.Text.RegularExpressions;

namespace ClockTask;
class ClockTask
{
    static void Main(string[] args)
    {
        int hour = GetHour();
        int minutes = GetMinutes();
        double angle = CalculateAngle(hour, minutes);
        PrintAngle(angle);
    }

    static int GetHour()
    {
        int hour;
        while (true)
        {
            Console.Write("Enter hour: ");
            string input = Console.ReadLine() ?? "";
            if (input != null && Regex.IsMatch(input, @"^[1-9]\d{0,1}$") && int.TryParse(input, out hour) && (hour >= 1 && hour <= 12))
                break;
            Console.WriteLine("Invalid input. Please enter a valid hour (1-12) with max 2 digits and no leading zero");
        }
        return hour;
    }

    static int GetMinutes()
    {
        int minutes;
        while (true)
        {
            Console.Write("Enter minutes: ");
            string input = Console.ReadLine() ?? "";
            if (input != null && Regex.IsMatch(input, @"^[1-9]\d{0,1}$") && int.TryParse(input, out minutes) && (minutes >= 1 && minutes <= 59))
                break;
            Console.WriteLine("Invalid input. Please enter a valid minute (1-59) with max 2 digits and no leading zero");
        }
        return minutes;
    }

    static double CalculateAngle(int hour, int minutes)
    {
        if (hour == 12 && minutes == 0)
        {
            return 0;
        }
        double angle = Math.Abs((hour * 30 + (0.5 * minutes)) - (minutes * 6));
        return Math.Min(angle, 360 - angle);
    }

    static void PrintAngle(double angle)
    {
        Console.WriteLine("Angle between hour and minute arrows: " + angle + " degrees");
    }
}