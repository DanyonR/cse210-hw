using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        string askToPlay = "";

        while (playAgain != false)
        {
            int guessCount = 0;

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.WriteLine("\nI have chosen a number between 1 and 100!");
            Console.Write("Can you guess what it is? ");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);
            guessCount++;

            while (guess != number)
            {
                if (guess < number)
                {
                    Console.Write("Higher. Guess again: ");
                    userGuess = Console.ReadLine();
                    guess = int.Parse(userGuess);
                    guessCount++;
                }
                else
                {
                    Console.Write("Lower. Guess again: ");
                    userGuess = Console.ReadLine();
                    guess = int.Parse(userGuess);
                    guessCount++;
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Would you like to play again? ");
            askToPlay = Console.ReadLine();
            string askToPlayLower = askToPlay.ToLower();
            if (askToPlayLower == "yes")
            {
                Console.WriteLine("\nOkay, let's play!");
            }
            else
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}