using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variable cki
            ConsoleKeyInfo cki;

            //Writes the action message
            Console.WriteLine("Please enter your name");

            //Reads the users input
            string name = Console.ReadLine();

            //Writes the welcome message with the user input
            Console.WriteLine($"Welcome {name}");

            //Assigning variable to cki
            //Console.ReadKey reads when a key is pressed
            cki = Console.ReadKey();

            //Writes what key is pressed
            Console.Write(" --- You Pressed ");
            Console.WriteLine(cki.Key.ToString());

            //test

            //Section below writes user input without variables
            
            //Writes action message
            Console.WriteLine("Please enter your name");
            
            //Writes welcome message based on user input
            Console.WriteLine("Welcome " + Console.ReadLine());

            //Pauses the program
            Console.ReadLine();
        }
    }
}
