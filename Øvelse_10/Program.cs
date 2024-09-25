using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_10
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            //Lav en funktion der kan skrive en forud bestemt tekst ud til skærmen
            //Calls function WriteSomething and pauses
            WriteSomething();
            Console.ReadLine();
        }

        /// <summary>
        /// Writes "Aloha" to the console
        /// </summary>
        static void WriteSomething()
        {
            Console.WriteLine("Aloha");
        }
        */
        /*
        static void Main(string[] args)
        {
            //Lav en funktion der kan skrive en tekst der med sendes som parameter ud til skærmen
            //Calls function WriteSomething with parameter and pauses
            WriteSomething("This is a message");
            Console.ReadLine();

        }

        /// <summary>
        /// Writes a message based on parameters
        /// </summary>
        /// <param name="message"></param>
        static void WriteSomething(string message)
        {
            Console.WriteLine(message);
        }
        */
        /*
        static void Main(string[] args)
        {
            //Lav en funktion der kan returnere en værdi
            //Inserts to variable and writes returned number and pauses
            int number = ReturnSomething();
            Console.WriteLine(number);
            Console.ReadLine();

        }

        /// <summary>
        /// Returns an int
        /// </summary>
        /// <returns></returns>
        static int ReturnSomething()
        {
            return 10;
        }
        */
        /*
        static void Main(string[] args)
        {
            //Lav funktioner til at udregne følgende: Lægge 2 tal sammen, Trække 2 tal fra hinanden, Gange 2 tal sammen, Dividere 2 tal
            //Calls functions and pauses
            Console.WriteLine(Addition(7, 17));
            Console.WriteLine(Subtraction(16, 4));
            Console.WriteLine(Multiplication(3, 5));
            Console.WriteLine(Division(37, 5));
            Console.ReadLine();
            
        }

        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static int Addition(int number1, int number2)
        {
            int result;

            result = number1 += number2;

            return result;
        }

        /// <summary>
        /// Subtracts two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static int Subtraction(int number1, int number2)
        {
            int result;

            result = number1 -= number2;

            return result;
        }

        /// <summary>
        /// Multiplies two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static int Multiplication(int number1, int number2)
        {
            int result;

            result = number1 *= number2;

            return result;
        }

        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static float Division(float number1, float number2)
        {
            float result;

            result = (number1 /= number2);

            return result;
        }
        */

        static void Main(string[] args)
        {
            //Lav en funktion der kan løse følgende matematisk udtryk og returnere resultatet: (X + B * 10) / Y
            //Calls function and pauses
            Console.WriteLine(TheBigSolve(7, 6, 3));
            Console.ReadLine();

        }

        /// <summary>
        /// Solves the equation: (X + B * 10) / Y
        /// </summary>
        /// <param name="X">First number</param>
        /// <param name="B">Second number</param>
        /// <param name="Y">Third number</param>
        /// <returns></returns>
        static float TheBigSolve(float X, float B, float Y)
        {
            float result;

            result = (X + B * 10) / Y;

            return result;
        }
    }
}
