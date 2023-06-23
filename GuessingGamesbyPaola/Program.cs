using System;

string secretWord = "technology";
string guess = "";
string hint = "It is the application of scientific knowledge to achieve practical ends.";
int guessCount = 0;
int guessLimit = 3;
bool outOfGuesses = false;


Console.WriteLine("            Welcome to The Guessing Game!");
Console.WriteLine("");
Console.WriteLine("        - guess ThE seCret word to win tHe game -");
Console.WriteLine("                 you have 3 guesses ");

while (guess != secretWord && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {
        Console.WriteLine("");
        Console.Write("Enter Guess: ");
        guess = Console.ReadLine();
        guessCount++;
        if (guessCount == 1 && guess != secretWord)
        {
            Console.WriteLine("You have " + 2 + " guesses left");
            Console.WriteLine("(ToT)");
            Console.WriteLine("");
        }
        if (guessCount == 2 && guess != secretWord)
        {
            Console.WriteLine("You have " + 1 + " guesses left");
            Console.WriteLine("(O_o)");
            Console.WriteLine("");
            Console.WriteLine("Type <H> to get a Hint or any Key to continue");
            while (Console.ReadKey().Key == ConsoleKey.H)
            {
                Console.WriteLine("");
                Console.WriteLine(hint);
            }
        }
    }
    else
    {
        outOfGuesses = true;

    }
}
    if (outOfGuesses)
    {
        Console.WriteLine("Sorry, try again another time...");
        Console.WriteLine("           (×_×)");
    }
    else 
    {
        Console.WriteLine("Congratulations, You Win!");
        Console.WriteLine("       d(=^`w`^=)b");
    }
