using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        // Fields
        private int hunger;
        private int thirst;
        private int waste;
        private int boredom;
        private int tired;
        private int anger;

        // Properties
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        public int Tired
        {
            get { return this.tired; }
            set { this.tired = value; }
        }
        public int Anger
        {
            get { return this.anger; }
            set { this.anger = value; }
        }

        // Constructor
        public VirtualPet()
        {

        }

        public void Tick()
        {
            hunger++;
            thirst++;
            waste++;
            boredom++;
            tired++;

            if(tired >= 20)
            {
                Console.WriteLine("Your Pet Rock has collapsed in exhaustion. Little fella just needs a nap.");
                Sleep();
                tired++;
                Console.ReadLine();
            }
            else if (thirst >= 15)
            {
                anger++;
                Console.WriteLine("Your Pet Rock has resorted to drinking from the toilet like an uncivilized beast.");
                Drink();
                thirst++;
                Console.ReadLine();
            }
            else if (hunger >= 15)
            {
                anger++;
                Console.WriteLine("Desperate with hunger, your Pet Rock has broken into your pantry and eaten all your breakfast cereal.");
                Feed();
                hunger++;
                Console.ReadLine();
            }
            else if (waste >= 10)
            {
                anger++;
                Console.WriteLine("Your Pet Rock has made a mess on the floor. He is deeply ashamed.");
                waste = 0;
                Console.ReadLine();
            }
            else if (boredom >= 5)
            {
                anger++;
                Console.WriteLine("Your Pet Rock made a passive aggressive Facebook post about how you never play with him.");
                Console.ReadLine();
            }
            else
            {
                
            }
        }

        public void Feed()
        {
            if(hunger <= 0)
            {
                Console.WriteLine("But your Pet Rock won't eat.");
                Console.ReadLine();
            }
            else
            { 
                hunger = -1;
                thirst++;
                waste = waste + 5;
            }
        }
        
        public void Drink()
        {
            if(thirst <= 0)
            {
                Console.WriteLine("But not this time. He must not be thirsty.");
                Console.ReadLine();
            }
            else
            {
                thirst = -1;
                waste++;
            }
        }

        public void Play()
        {
            if(tired >= 15)
            {
                Console.WriteLine("But Jeffrey is too tired to play.");
                Console.ReadLine();
            }
            else
            {
                boredom = -1;
                hunger++;
                thirst++;
                tired = tired + 5;
            }
        }

        public void Walk()
        {
            if (tired >= 10)
            {
                Console.WriteLine("But Jeffrey is too tired for a walk.");
                Console.ReadLine();
            }
            else
            {
                waste = -1;
                boredom = -1;
                hunger = hunger + 5;
                thirst = thirst + 5;
                tired = tired + 10;
            }
        }

        public void Sleep()
        {
            if(tired < 10)
            {
                Console.WriteLine("Your Pet Rock wasn't sleepy after all.");
                Console.ReadLine();
            }
            tired = -1;
            hunger++;
            thirst++;
        }


    }
}
