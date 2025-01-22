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

            Console.WriteLine($"\n\nHello, {firstName} {lastName}!");
            Console.WriteLine($"Your current age is {userAge}.");
            Console.WriteLine($"In 5 years, you will be {futureAge}.");
            Console.WriteLine($"The original price of the item is ${productPrice}.");
            
            if (isStudent)
            {
                Console.WriteLine($"As a student, the price is ${studentPrice}.");
            }
                else
            {
                Console.WriteLine($"If you were a student, the price would be ${studentPrice}.");
            }

            if (userAge >= 60)
            {
                Console.WriteLine($"As a senior, your price would be ${seniorPrice}.");
            }
            else
            {
                Console.WriteLine($"If you were a seinor, the price would be ${seniorPrice}.");
            }
      
        }
    }
}
