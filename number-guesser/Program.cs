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
            GetAppInfo();

            GreetUser();

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
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number.");

                        //keep going
                        continue;
                    }

                    //parse user input into int and put into guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //tell user it's the wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again.");
                    }
                }

                //output success message for correct guess
                PrintColorMessage(ConsoleColor.Green, "Winner Winner, Chicken Dinner!!!");

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


        //App Functions 

        static void GetAppInfo()
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
        }

        static void GreetUser()
        {
            //asks user's name
            Console.WriteLine("What is your name?");

            //user input for name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0}. Let's play a game...", inputName);
        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //tell user it's not a number
            Console.WriteLine(message);

            //resets text color back to default
            Console.ResetColor();
        }
    }
}
