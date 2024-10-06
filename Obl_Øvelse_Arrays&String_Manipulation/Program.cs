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
        //Assign variable
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
            Console.WriteLine("Welcome to the Quizgame!");
            Console.WriteLine("Your goal is to guess a randomly selected word!");
            Console.WriteLine("You have 5 lives to guess the word before you loose!");
            Console.WriteLine("Do you wanna play? y/n");
            playing = gameStart = Console.ReadLine();

            while (gameStart == "y")
            {
                Console.Clear();
                life = 3;
                Array.Clear(guessedLetters, 0, guessedLetters.Length);
                SetupWord();

                while (playing == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Life left: " + life);
                    Console.WriteLine("Letters guessed: ");
                    foreach (char l in guessedLetters)
                    {
                        Console.Write(l);
                    }

                    Console.WriteLine();

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

                Console.WriteLine("Want to play again? y/n");
                gameStart = playing = Console.ReadLine();

            }

        }

        /// <summary>
        /// Randomizes one of the 25 random words
        /// </summary>
        static void SetupWord()
        {

            rndWord = rnd.Next(0, 25);
            currentWord = words[rndWord];

        }

        /// <summary>
        /// Takes user input and checks it to the current word
        /// </summary>
        static void GuessLetter()
        {
            char guess = Convert.ToChar(Console.ReadLine());

            if (currentWord.Contains(guess) && !guessedLetters.Contains(guess))
            {

            }
            else
            {
                life--;
            }

            guessedLetters = guessedLetters.Append(guess).ToArray();
        }

        /// <summary>
        /// Checks if the player has won or lost
        /// </summary>
        static void WinCondition()
        {
            if (life == 0)
            {
                playing = "n";
                Console.WriteLine("You lost!");
            }

            bool wordComplete = true;

            foreach (char c in currentWord)
            {
                if (!guessedLetters.Contains(c))
                    wordComplete = false;
            }

            if (wordComplete == true)
            {
                playing = "n";
                Console.WriteLine("You Won!");
            }
        }
    }
}
