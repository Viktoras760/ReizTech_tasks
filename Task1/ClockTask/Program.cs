using System;

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
            if (int.TryParse(Console.ReadLine(), out hour) && (hour >= 0 && hour <= 11))
                break;
            Console.WriteLine("Invalid input. Please enter a valid hour (0-11)");
        }
        return hour;
    }

    static int GetMinutes()
    {
        int minutes;
        while (true)
        {
            Console.Write("Enter minutes: ");
            if (int.TryParse(Console.ReadLine(), out minutes) && (minutes >= 0 && minutes <= 59))
                break;
            Console.WriteLine("Invalid input. Please enter a valid minute (0-59)");
        }
        return minutes;
    }

    static double CalculateAngle(int hour, int minutes)
    {
        double angle = Math.Abs((hour * 30 + (0.5 * minutes)) - (minutes * 6));
        return Math.Min(angle, 360 - angle);
    }

    static void PrintAngle(double angle)
    {
        Console.WriteLine("Angle between hour and minute arrows: " + angle + " degrees");
    }
}