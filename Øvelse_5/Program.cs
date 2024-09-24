using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "bruh64";
            string password = "password";
            string usernamenew = "";
            string passwordnew = "";

            Console.WriteLine("Dansk eller/or English?");

            if (Console.ReadLine() == "Dansk")
            {
                Console.WriteLine("Velkommen, er du over 18 år gammel?");

                if (Console.ReadLine() == "Ja")
                {
                    Console.WriteLine("Log ind eller Opret bruger?");

                    if (Console.ReadLine() == "Opret bruger")
                    {
                        Console.WriteLine("Indtast dit brugernavn");
                        usernamenew = Console.ReadLine();

                        Console.WriteLine("Indtast dit kodeord");
                        passwordnew = Console.ReadLine();
                    }

                    Console.WriteLine("Indtast dit brugernavn");
                    if (Console.ReadLine() == username || Console.ReadLine() == usernamenew)
                    {
                        Console.WriteLine("Indtast dit kodeord");
                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Velkommen " + username);
                            Console.ReadLine();
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Beklager, du er ikke gammel nok til at logge ind");
                    Thread.Sleep(2000);
                }
            }

            else
            {
                Console.WriteLine("Welcome, Are you over the age of 18?");

                if (Console.ReadLine() == "Yes")
                {
                    Console.WriteLine("Enter your username");
                    if (Console.ReadLine() == username)
                    {
                        Console.WriteLine("Enter your password");
                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Welcome " + username);
                            Console.ReadLine();
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Sorry, You are not old enough to enter");
                    Thread.Sleep(2000);
                }
            }
            
        }
    }
}
