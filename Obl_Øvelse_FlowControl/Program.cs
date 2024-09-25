using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Obl_Øvelse_FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            int roundCounter = 1;
            int playerWins = 0;
            int computerWins = 0;
            int Ties = 0;
            int computerRandom = 0;
            int milliseconds = 2000;
            string computerChoice = string.Empty;
            string playerChoice = string.Empty;
            Random rnd = new Random();

            Console.WriteLine("Welcome to rock, paper, Scicors!");
            Console.WriteLine("At any time write Quit to exit the program");

            while (playing == true)
            {
                Thread.Sleep(milliseconds);
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
                Console.WriteLine("Player Wins: " + playerWins);
                Console.WriteLine("Computer Wins: " + computerWins);
                Console.WriteLine("Ties: " + Ties);
                Console.WriteLine("Rock, Paper, Scicors?");
                playerChoice = Console.ReadLine();

                if (playerChoice == "Quit")
                {
                    return;
                }

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("You and the computer picked the same: " + computerChoice);
                    Console.WriteLine("The game is a tie");
                    Ties++;
                }

                if (playerChoice == "Rock" && computerChoice == "Scicors")
                {
                    Console.WriteLine("Rock beats Scicors");
                    Console.WriteLine("Player Wins!");
                    playerWins++;
                }

                if (playerChoice == "Paper" && computerChoice == "Rock")
                {
                    Console.WriteLine("Paper beats Rock");
                    Console.WriteLine("Player Wins!");
                    playerWins++;
                }

                if (playerChoice == "Scicors" && computerChoice == "Paper")
                {
                    Console.WriteLine("Scicors beats Paper");
                    Console.WriteLine("Player Wins!");
                    playerWins++;
                }

                if (playerChoice == "Rock" && computerChoice == "Paper")
                {
                    Console.WriteLine("Paper beats Rock");
                    Console.WriteLine("Computer Wins!");
                    computerWins++;
                }

                if (playerChoice == "Paper" && computerChoice == "Scicors")
                {
                    Console.WriteLine("Scicors beats Paper");
                    Console.WriteLine("Computer Wins!");
                    computerWins++;
                }

                if (playerChoice == "Scicors" && computerChoice == "Rock")
                {
                    Console.WriteLine("Rock beats Scicors");
                    Console.WriteLine("Computer Wins!");
                    computerWins++;
                }

                roundCounter++;
            }

        }
    }
}
