using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static string correctWord = "hangman";
        static char[] letters;

        static Player player;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();


        }
        private static void StartGame()
        {
            System.Console.WriteLine("Starting the game...");
            letters = new char[correctWord.Length];
            for (int i = 0; i < letters.Length; i++)
                letters[i] = '-';
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            System.Console.WriteLine("Asking user for name");
            string input = Console.ReadLine();
            if (input.Length < 2)
            {
                AskForUsersName();
            }
            else
            {
                player = new Player(input);
            }
        }

        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
            } while (correctWord != new string(letters));

        }

        private static void CheckLetter(char guessedLetter)
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                {
                    letters[i] = guessedLetter;
                    player.Score++;
                }

            }
        }

        static void DisplayMaskedWord()
        {
            System.Console.WriteLine("Displaying masked word...");
            foreach (char c in letters)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        static char AskForLetter()
        {
            string input;
            do
            {
                Console.WriteLine("Enter a letter");
                input = Console.ReadLine();
            } while (input.Length != 1);

            var letter = input[0];

            if (!player.GuessedLetters.Contains(letter))
                player.GuessedLetters.Add(letter);
            return input[0];
        }

        private static void EndGame()
        {
            System.Console.WriteLine("Game over...");
            System.Console.WriteLine($"Guesses: {player.GuessedLetters.Count}");
            System.Console.WriteLine($"Score: {player.Score}");
            System.Console.WriteLine($"Thanks for playing {player.Name}");
        }
    }
}
