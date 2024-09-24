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
            string name;
            int guessNumber;
            int difference;
            int milliseconds = 2000;

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            Console.WriteLine(randomNumber);

            Console.WriteLine("WELCOME");
            Thread.Sleep(milliseconds);
            Console.WriteLine("TO");
            Thread.Sleep(milliseconds);
            Console.WriteLine("THE");
            Thread.Sleep(milliseconds);
            Console.WriteLine("GAMESHOW!");
            Thread.Sleep(milliseconds);
            Console.WriteLine("Contestant! What is your name?");

            name = Console.ReadLine();

            Console.WriteLine(name + " huh? What a wierd name...");
            Thread.Sleep(milliseconds);
            Console.WriteLine("Anyways, " + name + " Guess a number between 1 and 100 and you will be the winner of a big big price!");

            guessNumber = Convert.ToInt32(Console.ReadLine());

            difference = Math.Abs(randomNumber - guessNumber);

            if (difference == 0)
            {
                Console.WriteLine("Congratulations!!! " + name + " You won the big big price of...");
                Thread.Sleep(milliseconds);
                Console.WriteLine("NOTHING!!!");
                Thread.Sleep(milliseconds);
                Console.WriteLine("Now, get out... Use the enter key to leave");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("and the number is is... ");
                Thread.Sleep(milliseconds);
                Console.WriteLine(randomNumber);
                Thread.Sleep(milliseconds);
                Console.WriteLine("Ooooh, Sorry. You didn't guess correct...");
                Thread.Sleep(milliseconds);
                Console.WriteLine("You were only... " + difference + " off from the actual number");
                Thread.Sleep(milliseconds);
                Console.WriteLine("TOO BAD");
                Console.WriteLine("You know what happens next...");

                Console.WriteLine("Press enter to RUN!");
                Console.ReadLine();
            }
            
        }
    }
}
