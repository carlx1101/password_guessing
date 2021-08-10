using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess2
{
    class Program
    {
        static void Main(string[] args)
        {

            info();
            Console.WriteLine("What is your name:");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, welcome to game!", name);

            while (true) { 

            // int correctNum = 1;

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int guess = 0;


            Console.WriteLine("Guess a fking number:");

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();
                // data validation 
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("you dont understand what is number ?");
                    continue;
                }

                guess = Int32.Parse(input);
              
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red ;
                    Console.WriteLine("you dumb");
                    Console.ResetColor();
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("you are correct!");

                Console.WriteLine("Play again ? y/n");

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
        static void info()
        {
            // defining var 
            string appName = "Number Guuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Carl";

            // change title color 
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("{0}: Version  {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}
