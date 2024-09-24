using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string faction;
            string race = string.Empty;
            string characterClass = string.Empty;
            string name = string.Empty;

            Console.WriteLine("Welcome the the character creator!");
            Console.WriteLine("Please select a faction for your character (The grand order, The mechanical alliance, The savage sector)");

            faction = Console.ReadLine();

            switch (faction)
            {
                case "The grand order":
                    Console.WriteLine("Select a race to play (Gnome or Elf)");
                    race = Console.ReadLine();
                    switch (race)
                    {
                        case "Gnome":
                            Console.WriteLine("Select a class to play (Druid or Monk)");
                            characterClass = Console.ReadLine();
                            switch (characterClass)
                            {
                                case "Druid":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                                case "Monk":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;
                            }
                            break;

                        case "Elf":
                            Console.WriteLine("Select a class to play (Ranger or Bard)");
                            characterClass = Console.ReadLine();
                            switch (characterClass)
                            {
                                case "Ranger":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                                case "Bard":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;
                            }
                            break;
                    }

                    break;

                case "The mechanical alliance":
                    Console.WriteLine("Select a race to play (Dwarf or Dragonborn)");
                    race = Console.ReadLine();
                    switch (race)
                    {
                        case "Dwarf":
                            Console.WriteLine("Select a class to play (Rouge or Warlock)");
                            characterClass = Console.ReadLine();
                            switch (characterClass)
                            {
                                case "Rouge":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                                case "Warlock":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;
                            }
                            break;

                        case "Dragonborn":
                            Console.WriteLine("Select a class to play (Paladin or Artificer)");
                            characterClass = Console.ReadLine();
                            switch (characterClass)
                            {
                                case "Paladin":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                                case "Artificer":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;
                            }
                            break;
                    }
                    break;

                case "The savage sector":
                    Console.WriteLine("Select a race to play (Human or Orc)");
                    race = Console.ReadLine();
                    switch (race)
                    {
                        case "Human":
                            Console.WriteLine("Select a class to play (Cleric or Fighter)");
                            characterClass = Console.ReadLine();
                            switch (characterClass)
                            {
                                case "Cleric":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                                case "Fighter":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                            }
                            break;

                        case "Orc":
                            Console.WriteLine("Select a class to play (Barbarian or Wizard)");
                            characterClass = Console.ReadLine();
                            switch (characterClass)
                            {
                                case "Barbarian":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;

                                case "Wizard":
                                    Console.WriteLine("Please enter your characters name");
                                    name = Console.ReadLine();
                                    break;
                            }
                            break;
                    }
                    break;

            }
            Console.WriteLine("you are apart of the " + faction);
            Console.WriteLine("You are a " + race);
            Console.WriteLine("You will play as a " + characterClass);
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Let the adventure begin!");
            Console.ReadLine();

        }
    }
}
