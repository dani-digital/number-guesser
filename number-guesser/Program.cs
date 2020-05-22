using System;

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


        }
    }
}
