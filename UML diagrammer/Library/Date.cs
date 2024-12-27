using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Date
    {
        public int Year {  get; private set; }
        public int Month { get; private set; } 
        public int Day { get; private set; }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public static Date CreateWithValidation()
        {
            int year, month, day;

            while (true)
            {
                try
                {
                    Console.Write("Enter year: ");
                    year = int.Parse(Console.ReadLine());

                    Console.Write("Enter month: ");
                    month = int.Parse(Console.ReadLine());

                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("impossible");
                        continue;
                    }

                    Console.Write("Enter day: ");
                    day = int.Parse(Console.ReadLine());

                    if (day < 1 || day > 31)
                    {
                        Console.WriteLine("impossible");
                        continue;
                    }

                    return new Date(year, month, day);
                }
                catch (FormatException)
                {
                    Console.WriteLine("impossible");
                    continue;
                }
            }
        }

        public int GetDay()
        { return Day; }

        public int GetMonth() => Month;
        public int GetYear() => Year;

        public Date Copy() => new Date(Year, Month, Day); //laver en kopi af objektets nuværende dato uden at den derved ændrer på originalen 

        public override bool Equals(object obj)
        {
            if (obj is Date date)
            {
                return Year == date.Year && Month == date.Month && Day == date.Day;
            }
            return false;
        }

        public override string ToString() => $"{Year}-{Month:D2}-{Day:D2}"; //D2 = to digits. Output eksempel: 2024-12-06


    }
}
