using System;

namespace DisplayInfo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me about your self");// Get first name from user input

            Console.WriteLine("What is your first name?");// Get first name from user input
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");// Get last name from user input
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your favorite number?");//Get their favorite number
            int favNumber = int.Parse(Console.ReadLine());
            if (favNumber > 10)
            {
                favNumber.Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            //else if (favNumber < 5)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //}

            Console.WriteLine("What is your favorite animal?");// Get their favorite animal
            string favAnimal = Console.ReadLine();

            // Once you have gotten all their info and stored it,
            // display it back to them.
            
             Console.WriteLine($"{firstName} {lastName}'s favorite number is {favNumber} and the favorite animal is {favAnimal}" );

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.

        }
    }
}
