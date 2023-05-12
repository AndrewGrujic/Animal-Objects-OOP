using System;
using System.ComponentModel.Design;
using System.Timers;

class Program
{
    public static void Main(string[] args)
    {
        Animal animal1 = new Animal("Dog", 4, true, true);

        Console.WriteLine(animal1.getSpeciesName() + " has " + animal1.getLegs() + " legs. " + animal1.hasFurText() + " " + animal1.hasTailText());

        Animal animal2 = new Animal("Cow", 4, true, true);
        Animal animal3 = new Animal("Snake", 0, false, false);
        Animal animal4 = new Animal("Chicken", 2, false, true);

        Console.WriteLine(animal2.getSpeciesName() + " has " + animal2.getLegs() + " legs. " + animal2.hasFurText() + " " + animal2.hasTailText());
        Console.WriteLine(animal3.getSpeciesName() + " has " + animal3.getLegs() + " legs. " + animal3.hasFurText() + " " + animal3.hasTailText());
        Console.WriteLine(animal4.getSpeciesName() + " has " + animal4.getLegs() + " legs. " + animal4.hasFurText() + " " + animal4.hasTailText());

    }

    public class Animal
    {
        private string speciesName;
        private int legs;
        private bool fur;
        private bool tail;

        public Animal(string mySpeciesName, int mylegs, Boolean myFur, bool hasTail)
        {
            speciesName = mySpeciesName;
            legs = mylegs;
            fur = myFur;
            tail = hasTail;
        }

        public string getSpeciesName()
        {
            return speciesName;
        }

        public void setSpeciesName(String mySpeciesName)
        {
            speciesName = mySpeciesName;
        }

        public int getLegs()
        {
            return legs;
        }

        public void setLegs(int myLegs)
        {
            this.legs = myLegs;
        }

        public Boolean getFur()
        {
            return fur;
        }

        public void setFur(Boolean myFur)
        {
            this.fur = myFur;
        }

        public String hasFurText()
        {
            String text = getSpeciesName() + " ";
            if (getFur() == true)
            {
                text = text + "has fur.";
            }
            else
            {
                text = text + "doesn't have fur.";
            }
            return text;
        }

        public bool getTail()
        {
            return tail;
        }

        public string hasTailText()
        {
            string text  = getSpeciesName() + " ";
            if (getTail() == true)
            {
                    text = text + "has a tail.";
            }
            else
            {
                text = text + "doesn't have a tail";
            }
            return text;
        }

    }
}