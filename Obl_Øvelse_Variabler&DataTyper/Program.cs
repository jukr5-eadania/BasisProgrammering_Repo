using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Obl_Øvelse_Variabler_DataTyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defining variables
            string name;
            int guessNumber;
            int difference;
            int milliseconds = 2000;

            //Defining random number
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            //test code to see code
            Console.WriteLine(randomNumber);

            //Writes a welcome message 
            Console.WriteLine("WELCOME");
            Thread.Sleep(milliseconds);
            Console.WriteLine("TO");
            Thread.Sleep(milliseconds);
            Console.WriteLine("THE");
            Thread.Sleep(milliseconds);
            Console.WriteLine("GAMESHOW!");
            Thread.Sleep(milliseconds);
            Console.WriteLine("Contestant! What is your name?");

            //Defines name based on user input
            name = Console.ReadLine();

            //Writes an introduction to the game
            Console.WriteLine(name + " huh? What a wierd name...");
            Thread.Sleep(milliseconds);
            Console.WriteLine("Anyways, " + name + " Guess a number between 1 and 100 and you will be the winner of a big big price!");

            //Defines guess based on user input
            guessNumber = Convert.ToInt32(Console.ReadLine());

            //Defines the difference in the guessnumber and the number the computer choose
            difference = Math.Abs(randomNumber - guessNumber);

            //Checks if the difference is 0
            if (difference == 0)
            {
                //Writes congratulations message and tells the player to leave
                Console.WriteLine("Congratulations!!! ");
                Thread.Sleep(milliseconds);
                Console.WriteLine(name + " you won the big big price of...");
                Thread.Sleep(milliseconds);
                Console.WriteLine("NOTHING!!!");
                Thread.Sleep(milliseconds);
                Console.WriteLine("Now, get out... You're no fun...");
                Console.WriteLine("Use the enter key to leave");
                Console.ReadLine();
            }

            //Continues if the difference is not 0
            else
            {
                //Writes a message about how the player lost
                Console.WriteLine("and the number is... ");
                Thread.Sleep(milliseconds);
                Console.WriteLine(randomNumber);
                Thread.Sleep(milliseconds);
                Console.WriteLine("Ooooh, Sorry. You didn't guess correct...");
                Thread.Sleep(milliseconds);
                Console.WriteLine("You were only... " + difference + " off from the actual number");
                Thread.Sleep(milliseconds);
                Console.WriteLine("TOO BAD");
                Thread.Sleep(milliseconds);
                Console.WriteLine("You know what happens next...");
                Thread.Sleep(milliseconds);
                Console.WriteLine("Press enter to RUN!");
                Console.ReadLine();
            }
            
        }
    }
}
