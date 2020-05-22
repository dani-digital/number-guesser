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
            string name = "Dani ONeal";
            int age = 29;
            string loc = "Gray, GA";
            //start here
            //Console.WriteLine("Hello, " +name); //concat like JS
            //more efficient
            Console.WriteLine("{0} is {1} and lives in {2}.", name, age, loc);
        }
    }
}
