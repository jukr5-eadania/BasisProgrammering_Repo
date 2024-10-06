using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Obl_Øvelse_Arrays_String_Manipulation
{
    internal class Program
    {
        //Assign variables and arrays
        static Random rnd = new Random();
        static int rndWord;
        static string currentWord = string.Empty;
        static string[] words = new string[25] { "sale", "cheese", "employee", "infect", "ambition", "voyage", "barrier", "shame", "feminist", "preparation", "formulate", "overlook", "copy", "advice", "demonstrate", "border", "termnal", "teacher", "wealth", "execution", "familiar", "build", "screen", "detail", "lamb" };
        static char[] guessedLetters = new char[0];
        static int life = 5;
        static string playing;
        static string gameStart;

        static void Main(string[] args)
        {
            //intro text and asking player if they want to play
            Console.WriteLine("Welcome to the Quizgame!");
            Console.WriteLine("Your goal is to guess a randomly selected word!");
            Console.WriteLine("You have 5 lives to guess the word before you loose!");
            Console.WriteLine("Do you wanna play? y/n");
            playing = gameStart = Console.ReadLine();

            //Start loop
            while (gameStart == "y")
            {
                //Sets up a new game
                Console.Clear();
                life = 3;
                Array.Clear(guessedLetters, 0, guessedLetters.Length);
                SetupWord();

                //Game Loop
                while (playing == "y")
                {
                    //Writes info for the player
                    Console.Clear();
                    Console.WriteLine("Life left: " + life);
                    Console.WriteLine("Letters guessed: ");
                    foreach (char l in guessedLetters)
                    {
                        Console.Write(l);
                    }

                    Console.WriteLine();

                    //Writes the word they player is trying to guess
                    foreach (char c in currentWord)
                    {
                        if (guessedLetters.Contains(c))
                        {
                            Console.Write(c);
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }

                    Console.WriteLine();

                    GuessLetter();
                    WinCondition();
                }

                //After the game asks if the player wants to play again
                Console.WriteLine("Want to play again? y/n");
                gameStart = playing = Console.ReadLine();

            }

        }

        /// <summary>
        /// Randomizes one of the 25 random words
        /// </summary>
        static void SetupWord()
        {
            //Selects a random word from the array of words
            rndWord = rnd.Next(0, 25);
            currentWord = words[rndWord];

        }

        /// <summary>
        /// Takes user input and checks it to the current word
        /// </summary>
        static void GuessLetter()
        {
            //Converts user input to a char
            char guess = Convert.ToChar(Console.ReadLine());

            //If the user guesses incorrect they loose a life
            if (!currentWord.Contains(guess))
            {
                life--;
            }

            //If the user hasn't already guessed a specific letter it gets added to the list of letters guessed
            if (!guessedLetters.Contains(guess))
            {
                guessedLetters = guessedLetters.Append(guess).ToArray();
            }
        }

        /// <summary>
        /// Checks if the player has won or lost
        /// </summary>
        static void WinCondition()
        {
            //If the player has run out of lifes they lose and the game tells them the word and ends the game loop
            if (life == 0)
            {
                Console.Clear();
                Console.WriteLine("You lost!");
                Console.Write("The word was: ");
                foreach (char c in currentWord)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
                playing = "n";
            }

            bool wordComplete = true;

            //Checks to see if all the letters in the word are guessed
            foreach (char c in currentWord)
            {
                if (!guessedLetters.Contains(c))
                    wordComplete = false;
            }

            //If the word is guessed the player wins and the game tells them the word and ends the game loop
            if (wordComplete == true)
            {
                Console.Clear();
                Console.WriteLine("You won!");
                Console.Write("The word was: ");
                foreach (char c in currentWord)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
                playing = "n";
            }
        }
    }
}
