using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This line writes "Hello World" to the console
            Console.WriteLine("Hello World");

            //Writes a message to the user
            Console.WriteLine("Press any key to close the program");

            //Writes a message without a new line for the next text
            Console.Write("Console.Write writes text that does not make a new line for the next text.");

            //Writes a message with a new line for the next text
            Console.WriteLine(" Console.WriteLine writes text that adds a line after the text for the new text");

            //Colors the foreground magenta and the background white and outputs a line in that color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("This texts color is magenta while the background is white");

            //Makes the console say a beep sound when opening
            Console.Beep();

            //This line waits for user input (pauses the program)
            //If we don't do this the program will close right away
            Console.ReadLine();
        }
    }
}
