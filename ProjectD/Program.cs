using System;

namespace ProjectD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                studentName = "Pedro",
                studentID = 4
            };

            // Casting
            // Casting fails, so juniorStudent will be null
            JuniorStudent juniorStudent = student as JuniorStudent;

            if(juniorStudent == null)
                Console.WriteLine("Message: juniorStudent is NULL");
            else
                Console.WriteLine("Message: juniorStudent is NOT NULL");

            SeniorStudent seniorStudent = student as SeniorStudent;

            // Casting fails, so seniorStudent will be null
            if (seniorStudent == null)
                Console.WriteLine("Message: seniorStudent is NULL");
            else
                Console.WriteLine("Message: seniorStudent is NOT NULL");


            Console.WriteLine("\t");

            Student student1 = new JuniorStudent
            {
                studentID = 8,
                studentName = "Alice"
            };

            JuniorStudent juniorStudent1 = student1 as JuniorStudent;

            if(juniorStudent1 == null)
                Console.WriteLine("Message: juniorStudent1 is NULL.");
            else
                Console.WriteLine("Message: juniorStudent1 is NOT NULL.");

            SeniorStudent seniorStudent1 = student1 as SeniorStudent;

            if(seniorStudent1 == null)
                Console.WriteLine("Message: seniorStudent1 is NULL.");
            else
                Console.WriteLine("Message: seniorStudent1 is NOT NULL.");

            Console.WriteLine("\t");

            // We can convert derived types to base types!!!

            JuniorStudent juniorStudent2 = new JuniorStudent
            {
                studentName = "Peter",
                studentID = 24
            };

            Student S1 = juniorStudent2 as Student;

            if(S1 == null)
                Console.WriteLine("Message: S1 is NULL.");
            else
                Console.WriteLine("Message: S1 is NOT NULL.");

            SeniorStudent seniorStudent2 = new SeniorStudent
            {
                studentName = "Mariska",
                studentID = 37
            };

            Student S2 = seniorStudent2 as Student;

            if(S2 == null)
                Console.WriteLine("Message: S2 is NULL.");
            else
                Console.WriteLine("Message: S2 is NOT NULL.");


            // CAST OPERATOR

            Student theStudent = new Student
            {
                studentID = 1,
                studentName = "Adam"
            };

            JuniorStudent jrStudent = (JuniorStudent)theStudent;
        }
    }
}
