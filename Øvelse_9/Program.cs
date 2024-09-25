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
            int myInt;
            string myInput = string.Empty;

            while (true)
            {
                myInput = Console.ReadLine();

                myInt = int.Parse(myInput);

                Console.WriteLine(myInt);
                Console.ReadLine();

            }

        }
    }
}
