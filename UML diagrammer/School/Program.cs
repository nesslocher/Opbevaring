using System;


namespace Skole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Date birthday1 = new Date(1999, 5, 20);
            Student student1 = new Student(birthday1, 'M', "Mikkel", "Jensen", 10);

            Date birthday2 = new Date(1992, 5, 31);
            Student student2 = new Student(birthday2, 'F', "Mette", "Frederiksen", 0);

        }
    }
}