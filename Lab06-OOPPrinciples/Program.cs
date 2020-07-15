using Lab06_OOPPrinciples.Classes;
using System;
using System.Runtime;

namespace Lab06_OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Crocodile crocodile = new Crocodile("large", true, 4, "green");
            Horse horse = new Horse(6, true, 8, "yellow");
            GrizzlyBear grizzly = new GrizzlyBear(true, 1000, 6, "brown", true);
            Lion lion = new Lion(true, 8, 3, "tan", true);
            Sloth sloth = new Sloth(500, "slow", 10, "grey");
            Snake cobra = new Snake(11, "highly venomous", 3, "black");
            crocodile.Sleep();
            grizzly.Sleep();
            horse.Sweat();
            lion.Sweat();
        }
    }
}
