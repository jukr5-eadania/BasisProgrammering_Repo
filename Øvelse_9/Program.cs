using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assign variables
            int myInt;
            string myInput = string.Empty;

            //Parse:
            //Reads user input
            myInput = Console.ReadLine();

            //Parses user input to int
            myInt = int.Parse(myInput);

            //Writes parsed user input
            Console.WriteLine(myInt);

            //TryParse:
            //Reads user input
            myInput = Console.ReadLine();

            //TryParses user input
            if (int.TryParse(myInput, out myInt))
            {
                //If TryParse is successfull it writes result
                Console.WriteLine("myInt is: " + myInt);

            } else
            {
                //If TryParse is unsuccessfull it writes failure
                Console.WriteLine("Could not convert myInput, myInt is not valid");

            }

            //Pauses the program
            Console.ReadLine();

        }
    }
}
