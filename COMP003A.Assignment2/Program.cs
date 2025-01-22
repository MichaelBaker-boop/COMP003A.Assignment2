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

            Console.WriteLine("**********\nWelcome to the Discount Calculator!\n**********");

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            Console.Write("How old are you? ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you are interested in? ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? ");
            isStudent = bool.Parse(Console.ReadLine());

        }
    }
}
