using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet vPet = new VirtualPet();
            string input = "";
            Console.WriteLine("Pet Rock Simulator 2018");
            Console.WriteLine();
            Console.WriteLine("Your Pet Rock is named Jeffrey. You love him very much.");
            Console.ReadLine();
            Console.WriteLine();
            vPet.Hunger = 0;
            vPet.Thirst = 0;
            vPet.Waste = 0;
            vPet.Boredom = 0;
            vPet.Tired = 0;
            vPet.Anger = 0;

            while (input != "exit")
            {
                Console.WriteLine("JEFFREY");
                Console.WriteLine("Hunger: " + vPet.Hunger);
                Console.WriteLine("Thirst: " + vPet.Thirst);
                Console.WriteLine("Waste: " + vPet.Waste);
                Console.WriteLine("Boredom: " + vPet.Boredom);
                Console.WriteLine("Exhaustion: " + vPet.Tired);
                Console.WriteLine();
                Console.WriteLine("Enter the number of what you would like to do.");
                Console.WriteLine("1. Play With Your Pet Rock");
                Console.WriteLine("2. Walk Your Pet Rock");
                Console.WriteLine("3. Feed Your Pet Rock");
                Console.WriteLine("4. Give Your Pet Rock Water");
                Console.WriteLine("5. Have Your Pet Rock Take a Nap");
                Console.WriteLine("Or type exit to close program.");
                input = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (input == "exit")
                {
                    return;
                }
                else if (input == "1")
                {
                    Console.WriteLine("You challenge your Pet Rock to a rousing game of Backgammon.");
                    Console.ReadLine();
                    vPet.Play();
                }
                else if (input == "2")
                {
                    Console.WriteLine("You put a leash on your Pet Rock and take to the streets, where it can do its disgusting business.");
                    Console.ReadLine();
                    vPet.Walk();
                }
                else if (input == "3")
                {
                    Console.WriteLine("You give your Pet Rock a bowl a gravel to eat and mull the ethical ramifications.");
                    Console.ReadLine();
                    vPet.Feed();
                }
                else if (input == "4")
                {
                    Console.WriteLine("You drop your Pet Rock into some water and soon the water is gone. You ask no questions.");
                    Console.ReadLine();
                    vPet.Drink();
                }
                else if (input == "5")
                {
                    Console.WriteLine("You assume your Pet Rock is sleeping, but it's impossible to tell for sure.");
                    Console.ReadLine();
                    vPet.Sleep();
                }
                else
                {
                    Console.WriteLine("You stare at your Pet Rock and think about your life choices.");
                    Console.ReadLine();
                }

                vPet.Tick();
            }
        }
    }
}
