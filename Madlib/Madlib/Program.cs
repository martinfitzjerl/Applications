using System;
using System.Globalization;

namespace Madlib
{
    struct Lib
    {
        public string verb;
        public string adjective;
        public string noun;
        public string title;
        public string creature;
        public string adjectiveCreature;
        public string place;
        public string vehicle;
        public string weapon;
        public string cMagic;
        public string aura;
        public string name;
        public string weaponAction;
        public string faceChange;
        public string direction;
        public string structure;
        public string pronoun;
        public string possessivePronoun;

    }
    class Program
    {



        static void Main(string[] args)
        {
            Lib l = new Lib();
            Console.WriteLine("What is the noun? ex: boy, cat ");
            l.noun = Console.ReadLine();
            Console.WriteLine("What is the verb? ex: walked, ran");
            l.verb = Console.ReadLine();
            Console.WriteLine("What is the direction your character moved? ex: across, up");
            l.direction = Console.ReadLine();
            Console.WriteLine("What structure did your character traverse? ex: bridge, path");
            l.structure = Console.ReadLine();
            Console.WriteLine("What is an adjective for your character? ex: quickly, frantically ");
            l.adjective = Console.ReadLine();
            Console.WriteLine("What is the possessive pronoun used? ex: his, her ");
            l.possessivePronoun = Console.ReadLine();
            Console.WriteLine("What is your character's name? ex: Joe, John Doe");
            l.name = Console.ReadLine();
            Console.WriteLine("What is the character's title? ex: teacher, scholar, driver, nobleman ");
            l.title = Console.ReadLine();
            Console.WriteLine("What is the pronoun used for your character? ex: he, she, it ");
            l.pronoun = Console.ReadLine();
            Console.WriteLine("What kind of creature will your character find? ex: pixie, dragon ");
            l.creature = Console.ReadLine();
            Console.WriteLine("What is the creature doing? ex: eating, crawling ");
            l.adjectiveCreature = Console.ReadLine();
            Console.WriteLine("Where will you find a creature? ex: forest, cave ");
            l.place = Console.ReadLine();
            Console.WriteLine("The aura of the monster was..? ex: darkness, vibrance ");
            l.aura = Console.ReadLine();
            Console.WriteLine("Your character has a weapon, which is a..? ex: bow, gun ");
            l.weapon = Console.ReadLine();
            Console.WriteLine("The weapon does what? ex: shot fire, sprayed water ");
            l.weaponAction = Console.ReadLine();
            Console.WriteLine("The creature has what type of magic? ex: dark, fire ");
            l.cMagic = Console.ReadLine();
            Console.WriteLine("Your character made a face, what did it do? ex: turned red, engulfed inward with fear ");
            l.faceChange = Console.ReadLine();
            Console.WriteLine("What is the vehicle you'll use to escape? ex: scooter, broom ");
            l.vehicle = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The {0} {1} {2} the {3} {4} {5} name is {6}, the {7}. " +
                "\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(l.pronoun) + " soon found out there was a {9} {10} about in the {11}. There was a " +
                "particular {12} about the {9}. {6} pulled out {5} {13} and {14} at the {9}. The " + l.creature + " used its " + 
                l.cMagic + " magic. " + l.name+ "'s face " + l.faceChange + " and " + l.pronoun + " jumped on " + l.possessivePronoun + " " +
                l.vehicle + ". ", l.noun, l.verb, l.direction, l.structure, l.adjective, l.possessivePronoun, l.name, l.title, 
                l.pronoun, l.creature, l.adjectiveCreature, l.place, l.aura, l.weapon, l.weaponAction, l.cMagic, l.faceChange, l.vehicle);
            Console.ReadKey();
        }
    }
}
