using System;

namespace ProjectC 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                studentName = "Kevin",
                studentID = 7
            };

            // IS operator
            // It will return true, because "student" is of type Student.
            if(student is Student)
                Console.WriteLine(student.studentName + " is a student.");
            else
                Console.WriteLine(student.studentName + " is not a student!");

            // It will return false, becasue "student" is not a derived type
            if(student is JuniorStudent)
                Console.WriteLine(student.studentName + " is a junior student.");
            else
                Console.WriteLine(student.studentName + " is not a junior student!");

            if(student is SeniorStudent)
                Console.WriteLine(student.studentName + " is a senior student.");
            else
                Console.WriteLine(student.studentName + " is not a senior student!");

            Console.WriteLine("\t");

            // Derived type: Junior Student

            Student student1 = new JuniorStudent
            {
                studentName = "Andrea",
                studentID = 5
            };

            if(student1 is Student)
                Console.WriteLine(student1.studentName + " is a student.");
            else
                Console.WriteLine(student1.studentName + " is not a student.");

            if(student1 is JuniorStudent)
                Console.WriteLine(student1.studentName + " is a junior student.");
            else
                Console.WriteLine(student1.studentName + " is not a junior student!");

            if(student1 is SeniorStudent)
                Console.WriteLine(student1.studentName + " is a senior student.");
            else
                Console.WriteLine(student1.studentName + " is not a senior student!");

            Console.WriteLine("\t");

            // ...
            // Derived type: Senior student

            Student student2 = new SeniorStudent
            {
                studentName = "Pedro",
                studentID = 11
            };

            if (student2 is Student)
                Console.WriteLine(student2.studentName + " is a student.");
            else
                Console.WriteLine(student2.studentName + " is not a student.");

            if (student2 is JuniorStudent)
                Console.WriteLine(student2.studentName + " is a junior student.");
            else
                Console.WriteLine(student2.studentName + " is not a junior student!");

            if (student2 is SeniorStudent)
                Console.WriteLine(student2.studentName + " is a senior student.");
            else
                Console.WriteLine(student2.studentName + " is not a senior student!");
        }
    }
}