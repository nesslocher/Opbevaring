using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole
{
    public class Student
    {
        // Private attributes
        private char gender;
        private int grade;
        private Date birthday;
        private Name name;

        // Constructors
        public Student(Date birthday, char gender, string firstName, string lastName, int grade)
        {
            this.birthday = birthday;
            this.gender = gender;
            this.grade = grade;
            this.name = new Name(firstName, lastName);
        }

        // Methods
        public int GetAge(Date currentDate)
        {
            int age = currentDate.GetYear() - birthday.GetYear();
            if (currentDate.GetMonth() < birthday.GetMonth() ||
               (currentDate.GetMonth() == birthday.GetMonth() && currentDate.GetDay() < birthday.GetDay()))
            {
                age--;
            }
            return age;
        }

        public Date GetBirthday()
        {
            return birthday;
        }

        public char GetGender()
        {
            return gender;
        }

        public int GetGrade()
        {
            return grade;
        }

        public Name GetName()
        {
            return name;
        }

        public void SetGrade(int grade)
        {
            this.grade = grade;
        }
    }
}
