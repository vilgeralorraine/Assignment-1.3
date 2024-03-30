using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time Converter");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Seconds to Minutes: Type \'SM\'");
            Console.WriteLine("Minutes to Hours: Type \'MH\'");
            Console.WriteLine("Hours to Days: Type \'HD\'");
            Console.WriteLine("Days to Months Type \'DM\'");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            {
                string unit1 = "SM", unit2 = "MH", unit3 = "HD", unit4 = "DM";
                int jj = 4;

                while (jj > 0)
                {
                    Console.Write("Please select the units of time to be converted: ");
                    string name1 = Console.ReadLine();
                    if (name1 == unit1)
                    {
                        Console.Write("Enter seconds: ");
                        int seconds = int.Parse(Console.ReadLine());

                        int minutes = seconds / 60;
                        int rSeconds = seconds % 60;

                        Console.WriteLine(seconds + "seconds = " + minutes + " minute and " + rSeconds + " second/s.");
                        break;
                    }
                    else if (name1 == unit2)
                    {
                        Console.Write("Enter minutes: ");
                        int minutes = int.Parse(Console.ReadLine());

                        int hours = minutes / 60;
                        int rMinutes = minutes % 60;

                        Console.WriteLine(minutes + "minutes = " + hours + "hour and " + rMinutes + "minute/s.");
                        break;
                    }
                    else if (name1 == unit3)
                    {
                        Console.Write("Enter hours: ");
                        int hours = int.Parse(Console.ReadLine());

                        int days = hours / 24;
                        int rHours = hours % 24;

                        Console.WriteLine(hours + "hours = " + days + "day and " + rHours + "hour/s.");
                        break;
                    }
                    else if (name1 == unit4)
                    {
                        Console.Write("Enter a number of days: ");
                        int days = int.Parse(Console.ReadLine());

                        int months = days / 31;
                        int rDays = days % 31;

                        Console.WriteLine(days + "days = " + months + "month/s and " + rDays + "day/s.");
                        break;
                    }
                    else
                    {
                        jj--;
                        Console.Clear();
                        Console.WriteLine("Access denied!!!");
                    }
                }
            }

        }
    }
}
