using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defines array
            int[] numberArray = new int[7] { 12, 33, 532, 145, 1, 4565, 1 };

            //Writes the firth element in numberArray (0 always comes first in arrays)
            Console.WriteLine(numberArray[4]);

            //Changes the 3rd element in numberArray
            //numberArray[2] = 36562;

            //Writes all values in numberarray using a for loop
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            //Writes all values in numberarray using a foreach loop
            //foreach (int number in numberArray)
            //{
            //    Console.WriteLine(number.ToString());
            //}

            //Define variables
            string changing = "Yes";
            int element = 0;

            //While loop allowing user to continuously change a number in numberArray
            while (changing == "Yes")
            {
                Console.WriteLine("Do you want to change something in the numberArray?");
                changing = Console.ReadLine();
                if (changing != "Yes")
                {
                    break;
                }

                Console.WriteLine("What element do you want to change in numberArray");
                element = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("What number do you want to change the element to?");
                numberArray[element] = int.Parse(Console.ReadLine());

                Console.WriteLine("Updating array...");
                Thread.Sleep(2000);

                for (int i = 0; i < numberArray.Length; i++)
                {
                    Console.WriteLine(numberArray[i]);
                }

                Console.WriteLine("");
                Thread.Sleep(2000);
            }

            Console.WriteLine("");

            //Defines Array
            string[] stringArray = new string[10] { "Emilie", "Mads", "Malte", "Jeppe", "Irene", "Thomas", "Echo", "Emma", "Tobias", "Stephanie" };

            //Writes the firth element in stringArray (0 always comes first in arrays)
            //Console.WriteLine(stringArray[4]);

            //Changes the 3rd element in stringArray
            stringArray[2] = "Mario";

            //Writes all values in stringArray using a for loop
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //Writes all values in stringArray using a foreach loop
            //foreach (string name in stringArray)
            //{
            //    Console.WriteLine(name);
            //}

            //Update variables
            changing = "Yes";

            //While loop allowing user to continuously change a string in stringArray
            while (changing == "Yes")
            {
                Console.WriteLine("Do you want to change something in stringArray?");
                changing = Console.ReadLine();
                if (changing != "Yes")
                {
                    break;
                }

                Console.WriteLine("What element do you want to change in stringArray");
                element = int.Parse(Console.ReadLine()) - 1;
                
                Console.WriteLine("What number do you want to change the element to?");
                stringArray[element] = (Console.ReadLine());
                
                Console.WriteLine("Updating array...");
                Thread.Sleep(2000);
                
                for (int i = 0; i < stringArray.Length; i++)
                {
                    Console.WriteLine(stringArray[i]);
                }

                Console.WriteLine("");
                Thread.Sleep(2000);
            }

            Console.WriteLine("");
            Console.WriteLine("The program will now close");
            Thread.Sleep(2000);

        }
    }
}
