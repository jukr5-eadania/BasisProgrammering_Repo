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
            string language;
            string ageLimit;
            string login;

            Console.WriteLine("Dansk eller/or English?");
            language = Console.ReadLine();

            if (language == "Dansk")
            {
                Console.WriteLine("Velkommen, er du over 18 år gammel?");
                ageLimit = Console.ReadLine();

                if (ageLimit == "Ja")
                {
                    Console.WriteLine("Log ind eller Opret bruger?");
                    login =Console.ReadLine();

                    if (login == "Opret bruger")
                    {
                        Console.WriteLine("Indtast dit brugernavn");
                        username = Console.ReadLine();

                        Console.WriteLine("Indtast dit kodeord");
                        password = Console.ReadLine();
                    }

                    Console.WriteLine("Ny bruger oprettet, Log ind?");
                    login = Console.ReadLine();

                    if (login == "Log ind")
                    {
                        Console.WriteLine("Indtast dit brugernavn");
                        if (Console.ReadLine() == username)
                        {
                            Console.WriteLine("Indtast dit kodeord");
                            if (Console.ReadLine() == password)
                            {
                                Console.WriteLine("Velkommen " + username);
                                Console.ReadLine();
                            }

                            else
                            {
                                Console.WriteLine("Forkert kodeord, Genstart programmet for at prøve igen");
                                Console.ReadLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine("Forkert brugernavn, Genstart programmet for at prøve igen");
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

            if (language == "English")
            {
                Console.WriteLine("Welcome, are you over the age of 18?");
                ageLimit = Console.ReadLine();

                if (ageLimit == "Yes")
                {
                    Console.WriteLine("Log in or Create user?");
                    login = Console.ReadLine();

                    if (login == "Create user")
                    {
                        Console.WriteLine("Insert username");
                        username = Console.ReadLine();

                        Console.WriteLine("Inser password");
                        password = Console.ReadLine();
                    }

                    Console.WriteLine("New user added, Log in?");
                    login = Console.ReadLine();

                    if (login == "Log in")
                    {
                        Console.WriteLine("Insert username");
                        if (Console.ReadLine() == username)
                        {
                            Console.WriteLine("Insert password");
                            if (Console.ReadLine() == password)
                            {
                                Console.WriteLine("Welcome " + username);
                                Console.ReadLine();
                            }

                            else
                            {
                                Console.WriteLine("Wrong password, Restart program to try again");
                                Console.ReadLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine("Wrong username, Restart program to try again");
                            Console.ReadLine();
                        }
                    }

                }

                else
                {
                    Console.WriteLine("Sorry, you must be over the age of 18 to login");
                    Thread.Sleep(2000);
                }
            }
            
        }
    }
}
