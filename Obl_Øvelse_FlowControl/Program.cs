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
            //Assigning variables
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

            //Writes welcome message
            Console.WriteLine("Welcome to rock, paper, Scissors!");
            Console.WriteLine("At any time write Quit to exit the program");

            //While loop
            while (playing == true)
            {
                //Waits 2 seconds and randomizes computer choice
                Thread.Sleep(milliseconds);
                computerRandom = rnd.Next(1, 4);

                //Writes empty pace
                Console.WriteLine("");

                //Chooses computer choice based on random input
                switch (computerRandom)
                {
                    case 1:
                        computerChoice = "Rock";
                        //Console.WriteLine("The computer choose Rock!");
                        break;

                    case 2:
                        computerChoice = "Paper";
                        //Console.WriteLine("The computer choose Paper!");
                        break;

                    case 3:
                        computerChoice = "Scissors";
                        //Console.WriteLine("The computer choose Scissors!");
                        break;
                }
                
                //Writes round and wins info
                Console.WriteLine("Round: " + roundCounter);
                Console.WriteLine("Player Wins: " + playerWins);
                Console.WriteLine("Computer Wins: " + computerWins);
                Console.WriteLine("Ties: " + Ties);
                Console.WriteLine("Rock, Paper, Scissors?");
                
                //Allows the player to quit if they write Quit
                playerChoice = Console.ReadLine();

                if (playerChoice == "Quit")
                {
                    return;
                }

                //Results based on computer and player choice and applies points depending on who wins
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);
                    Console.WriteLine("You and the computer picked the same: " + computerChoice);
                    Console.WriteLine("The game is a tie");
                    Ties++;
                }

                if (playerChoice == "Rock" && computerChoice == "Scissors")
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);
                    Console.WriteLine("Rock beats Scissors");
                    Console.WriteLine("Player Wins!");
                    playerWins++;
                }

                if (playerChoice == "Paper" && computerChoice == "Rock")
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);
                    Console.WriteLine("Paper beats Rock");
                    Console.WriteLine("Player Wins!");
                    playerWins++;
                }

                if (playerChoice == "Scissors" && computerChoice == "Paper")
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);
                    Console.WriteLine("Scissors beats Paper");
                    Console.WriteLine("Player Wins!");
                    playerWins++;
                }

                if (playerChoice == "Rock" && computerChoice == "Paper")
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);
                    Console.WriteLine("Paper beats Rock");
                    Console.WriteLine("Computer Wins!");
                    computerWins++;
                }

                if (playerChoice == "Paper" && computerChoice == "Scissors")
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);
                    Console.WriteLine("Scissors beats Paper");
                    Console.WriteLine("Computer Wins!");
                    computerWins++;
                }

                if (playerChoice == "Scissors" && computerChoice == "Rock")
                {
                    Console.WriteLine("You Choose: " + playerChoice);
                    Console.WriteLine("The Computer Choose: " + computerChoice);                    
                    Console.WriteLine("Rock beats Scissors");
                    Console.WriteLine("Computer Wins!");
                    computerWins++;
                }

                //adds one to round counter
                roundCounter++;
            }

        }
    }
}
