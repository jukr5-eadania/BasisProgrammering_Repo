﻿using System;
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
            /*
            //Parse and TryParse
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
            */

            /*
            //Casting int to byte (Overflow)
            //Assign variables
            Byte castingByte;
            int castingInt = 300;

            //Casting int to byte with overflow without check
            castingByte = (byte)castingInt;

            //Writes overflowed byte and pauses program
            Console.WriteLine(castingByte);
            Console.ReadLine();
            
            //Checks overflowed byte which gives an error
            checked
            {
                castingByte = (byte)castingInt;
            }
            */

            //Casting float to int
            //Assign variables
            float myfloat = 2322.223f;
            int myInt;

            myInt = (int)myfloat;

            Console.WriteLine(myInt);
            Console.ReadLine();

        }
    }
}
