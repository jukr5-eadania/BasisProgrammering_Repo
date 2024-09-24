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
            //Asks user a question
            Console.WriteLine("What operation do you want to use? (Addition, Subtraction, Multiplication or Division)");

            //Defining variables
            string operation = Console.ReadLine();
            int firstNumber;
            int secondNumber;
            int inputFirstNumber;
            int inputSecondNumber;
            int sum;

                //Calling switch operation which asks the user what type of operation they want to use
                switch (operation)
                {
                    //Case for addition, asking the user for two numbers and adding them toghether while showing the original numbers and results
                    case "Addition":
                        Console.WriteLine("What is the first number you want to use?");
                        firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number you want to use?");
                        secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                        sum = firstNumber += secondNumber;
                        Console.WriteLine(inputFirstNumber + " plus " + inputSecondNumber + " is equal to " + sum);
                        break;

                    //Case for Subtraction, asking the user for two numbers and subtracting them from each other while showing the original numbers and results
                    case "Subtraction":
                        Console.WriteLine("What is the first number you want to use?");
                        firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number you want to use?");
                        secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                        sum = firstNumber -= secondNumber;
                        Console.WriteLine(inputFirstNumber + " minus " + inputSecondNumber + " is equal to " + sum);
                        break;

                    //Case for multiplication, asking the user for two numbers and mimltyplying them while showing the original numbers and results
                    case "Multiplication":
                        Console.WriteLine("What is the first number you want to use?");
                        firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number you want to use?");
                        secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                        sum = firstNumber *= secondNumber;
                        Console.WriteLine(inputFirstNumber + " times " + inputSecondNumber + " is equal to " + sum);
                        break;

                    //Case for Division, asking the user for two numbers and dividing them while showing the original numbers and results
                    case "Division":
                        Console.WriteLine("What is the first number you want to use?");
                        firstNumber = inputFirstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number you want to use?");
                        secondNumber = inputSecondNumber = Convert.ToInt32(Console.ReadLine());
                        sum = firstNumber /= secondNumber;
                        Console.WriteLine(inputFirstNumber + " divided " + inputSecondNumber + " is equal to " + sum);
                        break;

                    //If the user does not the correct case, they will be asked again
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
