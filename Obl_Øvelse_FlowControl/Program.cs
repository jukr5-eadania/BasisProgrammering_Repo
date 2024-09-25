using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obl_Øvelse_FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            int roundCounter = 1;
            int computerRandom = 0;
            string computerChoice = string.Empty;
            string playerChoice = string.Empty;
            Random rnd = new Random();

            Console.WriteLine("Welcome to rock, paper, Scicors!");
            Console.WriteLine("At any time write Quit to exit the program");

            while (playing == true)
            {
                computerRandom = rnd.Next(1, 4);

                switch (computerRandom)
                {
                    case 1:
                        computerChoice = "Rock";
                        Console.WriteLine("The computer choose Rock!");
                        break;

                    case 2:
                        computerChoice = "Paper";
                        Console.WriteLine("The computer choose Paper!");
                        break;

                    case 3:
                        computerChoice = "Scicors";
                        Console.WriteLine("The computer choose Scicors!");
                        break;
                }

                Console.WriteLine("Round: " + roundCounter);
                Console.WriteLine("Rock, Paper, Scicors?");
                playerChoice = Console.ReadLine();

                if (playerChoice == "Quit")
                {
                    //return;
                }

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("You and the computer picked the same. " + computerChoice + ". The game is a tie");
                }

                roundCounter++;
            }

        }
    }
}
