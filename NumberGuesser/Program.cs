// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;

GetAppInfo(); // calling GetAppInfo function

GreetUser(); // Ask for user's name and greet user

while (true)
{

    // Set initial default correct number
    //int correctNumber = 7;

    // Create a new random object
    Random random = new();

    // Init correct number
    int correctNumber = random.Next(1, 10);

    // Init guess variable
    int guess = 0;

    // Ask user for number
    Console.WriteLine("Guess a number from 1 to 10");

    // While guess is not correct
    while (guess != correctNumber)
    {
        // Get users input
        string input = Console.ReadLine();

        // Make sure it is a number
        if (!int.TryParse(input, out guess))
        {
            // Print error message
            PrintColorMessage(ConsoleColor.Red, "Please enter a valid number 1 to 10");

            // keep going
            continue;
        }

        // Caste to int and put into guess
        guess = int.Parse(input);

        // Match guess to correct number
        if (guess != correctNumber)
        {
            PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
        }
    }

    // Change text color
    Console.ForegroundColor = ConsoleColor.Yellow;

    // Tell user its the correct number
    Console.WriteLine("CORRECT!!! You guessed it!");

    // Reset text color
    Console.ResetColor();

    // As to play again?
    Console.WriteLine("Play Again? [Y or N]");

    // Get answer
    string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        continue;
    }
    else if (answer != "Y")
    {
        // Notify user game is over
        PrintColorMessage(ConsoleColor.Cyan, "Game over! Thank you for playing!");
        PrintColorMessage(ConsoleColor.Cyan, "Have a great day!");
        PrintColorMessage(ConsoleColor.Yellow, ":-)");

        return;
    }

}

// Get and display app info
void GetAppInfo()
{
    // Set app variables
    string appName = "Number Guesser";
    string appVersion = "1.0.0";
    string appAuthor = "Lisa. Credits to a Brad Traversy tutorial.";

    // Change text color
    Console.ForegroundColor = ConsoleColor.Green;

    // Write out app info
    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

    // Reset text color
    Console.ResetColor();
}

// Ask user's name and greet
void GreetUser()
{
    // Ask user's name
    Console.WriteLine("What is your name?");

    // Get user input
    string inputName = Console.ReadLine();

    Console.WriteLine("Hello {0}, Let's play a game...", inputName);
}

// Print color message
void PrintColorMessage(ConsoleColor color, string message)
{
    // Change text color
    Console.ForegroundColor = color;

    // Tell user its not number
    Console.WriteLine(message);

    // Reset text color
    Console.ResetColor();
}
