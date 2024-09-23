using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks for the users name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //Asks for the users age
            Console.WriteLine("How old are you?");
            byte age = Convert.ToByte(Console.ReadLine());

            //Asks for the users phone number
            Console.WriteLine("What is your phone number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());

            //Asks for the users country
            Console.WriteLine("What country do you live in?");
            string country = Console.ReadLine();

            //Asks for the users city
            Console.WriteLine("What city do you live in?");
            string city = Console.ReadLine();

            //Asks for the users city's postal code
            Console.WriteLine("What is your city's postal code");
            int postalCode = Convert.ToInt32(Console.ReadLine());

            //Asks for the users adress
            Console.WriteLine("What is your adress?");
            string adress = Console.ReadLine();

            //Outputs all user inputs
            Console.WriteLine("Name: " + name + Environment.NewLine + "Age: " + age + Environment.NewLine + "Phone Number: " + phoneNumber + Environment.NewLine + "Country " + country + Environment.NewLine + "City: " + city + Environment.NewLine + "Postal Code: " + postalCode + Environment.NewLine + "Adress: " + adress);

            //Pauses the program
            Console.ReadLine();         
        }
    }
}
