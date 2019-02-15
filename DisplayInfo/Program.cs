using System;

namespace DisplayInfo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me about your self");

            Console.WriteLine("What is your first name?");// Get first name from user input
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");// Get last name from user input
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your favorite number?");//Get their favorite number
            int favNumber = int.Parse(Console.ReadLine());
            


            Console.WriteLine("What is your favorite animal?");// Get their favorite animal
            string favAnimal = Console.ReadLine();

            // Once you have gotten all their info and stored it,
            // display it back to them.

            Console.Write($"{firstName} {lastName}'s favorite number is ");
            if (favNumber > 10)     // If their favorite number is greater than 10, display it in green.
            {
                Console.ForegroundColor = ConsoleColor.Green;
                
            }
            else if (favNumber < 5)// If their favorite number is less than 5, display it in red.
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else // If their favorite number is between 5 and 10, display it in blue.
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(favNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" and the favorite animal is {favAnimal}" );
            Console.WriteLine();

        
            

        }
    }
}
