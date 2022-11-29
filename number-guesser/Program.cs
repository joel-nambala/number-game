using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get application information
            GetApplicationInfo();

            // Get the name of the player
            GetUserName();

            while (true)
            {
                // Get the random number
                int correctNumber = GetRandomNumber();
                Console.WriteLine(correctNumber);

                // Game states
                int guessCount = 0;
                int guessLimit = 3;
                int guess = 0;

                while (guess != correctNumber)
                {
                    // Get the input from the user
                    string input = Console.ReadLine();

                    // Check if the input is  a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print a error message
                        PrintMessage(ConsoleColor.Red, "Please enter an actual number");

                        // Continue with the game
                        continue;
                    }

                    // Reassign the guess variabke
                    guess = Convert.ToInt32(input);

                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintMessage(ConsoleColor.Red, "Wrong answer. Please try again!");

                        // Continue with the game
                        continue;
                    }
                }

                // Print the success message
                PrintMessage(ConsoleColor.Yellow, "Correct answer...");

                // Play again
                Console.WriteLine("Play again? Y or N");

                // Get the answer from the user
                string answer = Console.ReadLine().ToLower();

                if(answer == "y")
                {
                    // Continue the game
                    continue;
                }else if(answer == "n")
                {
                    // Quit the game
                    break;
                }
            }

        }
        // Method to get application info
        static void GetApplicationInfo()
        {
            // Application info
            string appName = "Number guesser";
            string appAuthor = "Joel Nambala";
            string appVersion = "1.0.0";

            // Display to the UI
            // Change the foreground color
            Console.ForegroundColor = ConsoleColor.Green;

            // Display the info message
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Reset the color
            Console.ResetColor();
        }

        static void GetUserName()
        {
            // Get the input from the user
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            // Display the name with a greet message
            Console.WriteLine($"Welcome {userName}. Guess a number between 1 and 10 :)");
        }

        static int GetRandomNumber()
        {
            // Generate a random number
            Random random = new Random();

            // Specify the range
            int correctNumber = random.Next(1, 10);

            // Return the random number
            return correctNumber;
        }

        // Print message to the console
        static void PrintMessage(ConsoleColor color, string message)
        {
            // Change the foreground color
            Console.ForegroundColor = color;

            // Display the info message
            Console.WriteLine(message);

            // Reset the color
            Console.ResetColor();
        }
    }
}