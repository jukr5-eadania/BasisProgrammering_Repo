using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obl_Øvelse_Arrays_String_Manipulation
{
    enum Words
    {
        sale,
        cheese,
        employee,
        infect,
        ambition,
        voyage,
        barrier,
        shame,
        feminist,
        preparation,
        formulate,
        overlook,
        copy,
        advice,
        demonstrate,
        border,
        terminal,
        teacher,
        wealth,
        execution,
        familiar,
        build,
        screen,
        detail,
        lamb
    }
    internal class Program
    {
        //Assign variable
        static Array values = Enum.GetValues(typeof(Words));
        static Random rnd = new Random();
        static string currentWord = string.Empty;

        static void Main(string[] args)
        {
            //Assign variable
            string playing = "y";

            Console.WriteLine("Welcome to the Quizgame!");
            Console.WriteLine("Your goal is to guess a randomly selected word!");
            Console.WriteLine("You have X lives to guess the word before you die! :D");
            Console.WriteLine("Do you wanna play? y/n");

            while (playing == "y")
            {
                Console.WriteLine("Ha ha, you don't have a choice anyway. You are playing no matter what");

                SetupWord();
                Console.ReadLine();


            }
        }

        static void SetupWord()
        {
            Words randomword = (Words)values.GetValue(rnd.Next(values.Length));
        }
    }
}
