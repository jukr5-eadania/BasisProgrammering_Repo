using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What operation do you want to use? (Addition, Subtraction, Multiplication or Division)");

            string operation = Console.ReadLine();
            int firstNumber;
            int secondNumber;
            int inputFirstNumber;
            int inputSecondNumber;
            int sum;
            
            switch (operation)
            {
                case "Addition":
                    Console.WriteLine("What is the first number you want to use?");
                    firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to use?");
                    secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                    sum = firstNumber += secondNumber;
                    Console.WriteLine(inputFirstNumber + " plus " + inputSecondNumber + " is equal to " + sum);
                    break;

                case "Subtraction":
                    Console.WriteLine("What is the first number you want to use?");
                    firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to use?");
                    secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                    sum = firstNumber -= secondNumber;
                    Console.WriteLine(inputFirstNumber + " minus " + inputSecondNumber + " is equal to " + sum);
                    break;

                case "Multiplication":
                    Console.WriteLine("What is the first number you want to use?");
                    firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to use?");
                    secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                    sum = firstNumber *= secondNumber;
                    Console.WriteLine(inputFirstNumber + " times " + inputSecondNumber + " is equal to " + sum);
                    break;


                case "Division":
                    Console.WriteLine("What is the first number you want to use?");
                    firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to use?");
                    secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                    sum = firstNumber /= secondNumber;
                    Console.WriteLine(inputFirstNumber + " divided " + inputSecondNumber + " is equal to " + sum);
                    break;

                default:
                    Console.WriteLine("You did not write the correct thing");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                    
            }

            //Pauses the program
            Console.ReadLine();
        }
    }
}
