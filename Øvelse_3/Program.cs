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
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("What is your phone number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What country do you live in?");
            string country = Console.ReadLine();

            Console.WriteLine("What city do you live in?");
            string city = Console.ReadLine();

            Console.WriteLine("What is your city's postal code");
            int postalCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your adress?");
            string adress = Console.ReadLine();

            Console.WriteLine("Name: " + name + Environment.NewLine + "Age: " + age + Environment.NewLine + "Phone Number: " + phoneNumber + Environment.NewLine + "Country " + country + Environment.NewLine + "City: " + city + Environment.NewLine + "Postal Code: " + postalCode + Environment.NewLine + "Adress: " + adress);

            Console.ReadLine();         
        }
    }
}
