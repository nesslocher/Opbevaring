using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lejlighed
{
    public class MyDate
    {
        private int day { get; set; }
        private int month { get; set; }
        private int year { get; set; }

        public MyDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
            {
                Console.WriteLine("invalid day");
                //kald en standard dag? this.day = 1  ??
            }
            else { this.day = day; }
            
            if (month < 1 || month > 12)
            {
                Console.WriteLine("invalid month");
            }
            else { this.month = month; }

            if (year < 0)
            {
                Console.WriteLine("invalid year");
            }
            else { this.year = year; }
        }

        public MyDate() : this(1, 1, 2024) { }

        public int GetDay() => day;

        public int GetMonth() => month;

        public int GetYear() => year;

        public void Set(int day, int month, int year)
        {
            if (day < 1 || day > 31)
            {
                Console.WriteLine("invalid day");
            }
            else { this.day = day; }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("invalid month");
            }
            else { this.month = month; }

            if (year < 0)
            {
                Console.WriteLine("invalid year");
            }
            else { this.year = year; }
        }

        public MyDate Copy()
        {
            return new MyDate(day, month, year);
        }

        public override bool Equals(object obj)
        {
            if (obj is MyDate other)
            {
                return this.day == other.day && this.month == other.month && this.year == other.year;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(day, month, year);
        }


    }
}
