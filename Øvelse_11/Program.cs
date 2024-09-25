using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buggy_Code
{
    internal class Program
    {
        static int First = 12;
        static string message = "Hello World";
        static int number = 1;

        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(1, 2));
            WriteMessage(message);
            CountToNumber(5);
            WriteMessageWithCaps(false, message);
            Console.WriteLine(CalculateAverageValue(10, 20, 30));
            CalculateSum(3);
            WriteNumberWithSwitchCase();
            Console.ReadLine();
        }

        /// <summary>
        /// Lægger to tal sammen og returnerer resultatet. Hvis man giver den 1,2 skal den returnere 3.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        static int AddNumbers(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Skriver en besked ud til konsollen, skriver en beskedi konsollen, hvis man skriver Hello, skriver den Hello
        /// </summary>
        /// <param name="message">beskeden, som skrives ud</param>
        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Tæller til et tal, hvis der skrives 3 bør den skrive 1,2,3
        /// </summary>
        /// <param name="number">tallet der skal tælles til</param>
        static void CountToNumber(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Skriver beskeden med caps hvis bool parametret er true. Hvis der gives true og Hello, skal den skrive HELLO
        /// </summary>
        /// <param name="UseCaps">skal det skrives med caps</param>
        /// <param name="message">Beskeden der skal skrives</param>
        static void WriteMessageWithCaps(bool UseCaps, string message)
        {
            if (UseCaps == true)
            {
                Console.WriteLine(message.ToUpper());
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// Beregner gennemsnitsværdien af de givende tal. Hvis der indtastes 10,20,30 skal den returnere 20
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns>Gennemsnittet</returns>
        static float CalculateAverageValue(float first, float second, float third)
        {
            float sum = first + second + third;
            float average = sum / 3;
            return average;
        }

        /// <summary>
        /// Beregner den samlede sum op til det indtastede max tal hvis max er 5 skal den give 15
        /// </summary>
        static int CalculateSum(int max)
        {
            int sum = 0;

            for (int i = 1; i <= max; i++)
            {
                sum += i;
                Console.WriteLine($"Adding {i}, sum is now: {sum}");
            }
            return (sum);
        }

        /// <summary>
        /// Tager imod et tal mellem 1,2,3 og skriver ud til konsollen hvad der er indtastet.
        /// </summary>
        static void WriteNumberWithSwitchCase()
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number was 1");
                    break;
                case 2:
                    Console.WriteLine("The number was 2");
                    break;
                case 3:
                    Console.WriteLine("The number was 3");
                    break;
                default:
                    Console.WriteLine("Number was not 1, 2 or 3");
                    break;
            }

        }


    }
}
