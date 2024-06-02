using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Letter grade: A");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Letter grade: B");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Letter grade: C");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Letter grade: D");
            }
            else
            {
                Console.WriteLine("Letter grade: F");
            }
        }
    }
}