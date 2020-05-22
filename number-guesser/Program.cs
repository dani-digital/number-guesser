using System;
using System.Runtime.CompilerServices;

//function
namespace number_guesser
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dani O'Neal";

            //change text color
            Console.ForegroundColor = ConsoleColor.Magenta;

            //header for app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //resets text color back to default
            Console.ResetColor();

            //asks user's name
            Console.WriteLine("What is your name?");

            //user input for name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0}. Let's play a game...", inputName);

            while (true)
            {

                //init (set) correct number 
                //int correctNumber = 7;

                //new random object method - class - object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                //init (set) var for guess
                int guess = 0;

                //ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                //loop for incorrect guesses
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell user it's not a number
                        Console.WriteLine("Please enter a valid number from 1-10.");

                        //resets text color back to default
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //parse user input into int and put into guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell user it's the wrong number
                        Console.WriteLine("Wrong number. Please try again.");

                        //resets text color back to default
                        Console.ResetColor();
                    }
                }

                //output success message for correct guess

                //change text color
                Console.ForegroundColor = ConsoleColor.Green;

                //tell user it's the right number
                Console.WriteLine("You are correct!!!");

                //resets text color back to default
                Console.ResetColor();

                //play again
                Console.WriteLine("Play Again? [Y or N]");

                //get answer for replay, changes input to uppercase
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
