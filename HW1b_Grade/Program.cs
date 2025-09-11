// HW1b Grade

// Your Name: Samuel Ang
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine("What is your ID Number?");
            string ID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homework?");
            double homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = Convert.ToDouble(Console.ReadLine());

            double Exam1 = 0.15;
            double Exam2 = 0.25;
            double Exam3 = 0.25;
            double Homework = 0.20;
            double Participation = 0.15;

            double finalGrade = (homework * Homework) +
                                (participation * Participation) +
                                (quizzes * Exam1) +
                                (midterm * Exam2) +
                                (final * Exam3);

            Console.WriteLine($"{FirstName} {LastName} ({ID}), your final grade is {finalGrade:F2}%");

            Console.ReadKey();

        }
    }
}
