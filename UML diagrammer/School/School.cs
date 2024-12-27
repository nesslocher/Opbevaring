using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole
{
    public class School
    {
        private Date registration;
        private Name name;
        private List<Student> students;

        public School(Date registration, string name)
        {
            this.registration = registration;
            this.name = new Name(name, ""); // Assuming a single name string for simplicity
            this.students = new List<Student>();
        }
  
        public Name GetSchoolName()
        {
            return name;
        }

        public Date GetSchoolRegistrationDate()
        {
            return registration;
        }

        public void AddStudent(Date birthday, char gender, string firstName, string lastName, int grade)
        {
            students.Add(new Student(birthday, gender, firstName, lastName, grade));
        }

        public bool ExpelStudent(Student student)
        {
            return students.Remove(student);
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public int GetStudentCountByAge(int age, Date currentDate)
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.GetAge(currentDate) == age)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetStudentCountByGender(char gender)
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.GetGender() == gender)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetStudentCountByGrade(int grade)
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.GetGrade() == grade)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetStudentCountByName(Name searchName)
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.GetName().GetFullName() == searchName.GetFullName())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
