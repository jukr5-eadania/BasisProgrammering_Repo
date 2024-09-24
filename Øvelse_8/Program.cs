using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assigns variables
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int milliseconds = 500;

            //While loop that counts to 10
            while (count1 < 11)
            {
                Console.WriteLine("While loop: " + count1);
                count1 += 1;
                Thread.Sleep(milliseconds);
            }

            //Do...While loop that counts to 10
            do
            {
                Console.WriteLine("Do...While loop: " + count2);
                count2 += 1;
                Thread.Sleep(milliseconds);
            } while (count2 < 11);

            //For loop that counts to 10
            for (count3 = 0; count3 < 11; count3++)
            {
                Console.WriteLine("For loop: " + count3);
                Thread.Sleep(milliseconds);

            }

        }
    }
}
