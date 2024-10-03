using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Obl_Øvelse_Arrays_String_Manipulation
{
    internal class Program
    {
        //Assign variable
        static Random rnd = new Random();
        static string currentWord = string.Empty;
        static int rndWord;
        static string[] words = new string[25] {"sale", "cheese", "employee", "infect", "ambition", "voyage", "barrier", "shame", "feminist", "preparation", "formulate", "overlook", "copy", "advice", "demonstrate", "border", "termnal", "teacher", "wealth", "execution", "familiar", "build", "screen", "detail", "lamb"};

        static void Main(string[] args)
        {
            //Assign variable
            string playing = "n";
            int life = 3;
            
            Console.WriteLine("Welcome to the Quizgame!");
            Console.WriteLine("Your goal is to guess a randomly selected word!");
            Console.WriteLine("You have X lives to guess the word before you loose!");
            Console.WriteLine("Do you wanna play? y/n");
            playing = Console.ReadLine();

            while (playing == "y")
            {
                SetupWord();

                char myChar = currentWord[3];

                Console.WriteLine(myChar);

                Console.ReadLine();
            }

            Console.WriteLine("The program will now terminate");
            Thread.Sleep(1000);

        }

        /// <summary>
        /// Randomizes one of the 25 random words
        /// </summary>
        static void SetupWord()
        {
            
            rndWord = rnd.Next(0, 25);
            currentWord = words[rndWord];
            Console.WriteLine(currentWord);

        }
    }
}
