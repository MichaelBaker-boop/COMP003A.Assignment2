/*
    Author: Michael Baker
    Course: Comp003A
    Faculty: Jonathan Cruz
    Purpose: Discount Calculator
*/
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int userAge;
            double productPrice;
            bool isStudent;

            Console.WriteLine("***********************************\nWelcome to the Discount Calculator!\n***********************************");

            //User Inputs

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            Console.Write("How old are you? ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you are interested in? ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false) ");
            isStudent = bool.Parse(Console.ReadLine());

            // Calculations

            int futureAge = userAge + 5;
            double studentPrice = productPrice * 0.9;
            double seniorPrice = productPrice * 0.8;


            // Outputs

            Console.WriteLine("\n\n+***********************************");
            Console.WriteLine($"Hello, {firstName} {lastName}!");
            Console.WriteLine($"Your current age is {userAge}.");
            Console.WriteLine($"In 5 years, you will be {futureAge}.");
            Console.WriteLine($"The original price of the item is ${productPrice:F2}."); //The :F2 here keeps two decimal places on the output
            
            if (isStudent)
            {
                Console.WriteLine($"As a student, your discounted price is ${studentPrice:F2}.");
            }
            else
            {
                Console.WriteLine($"If you were a student, the discounted price would be ${studentPrice:F2}.");
            }

            if (userAge >= 60)
            {
                Console.WriteLine($"As a senior senior citizen, your discounted price is ${seniorPrice:F2}");
            }
            else
            {
                Console.WriteLine($"As a senior citizen, your discounted price would be ${seniorPrice:F2}.");
            }

            Console.WriteLine("***********************************");


        }
    }
}
