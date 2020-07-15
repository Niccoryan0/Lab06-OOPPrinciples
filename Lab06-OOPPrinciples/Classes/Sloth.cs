using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Sloth
    /// Parent Class - Herbivore
    /// </summary>
    public class Sloth : Herbivore
    {
        // Creepiness will always be very high
        public int Creepiness { get; set; }
        public string Speed { get; set; }

        public Sloth(int creepiness, string speed, int age, string color)
        {
            Creepiness = creepiness;
            Speed = speed;
            Age = age;
            Color = color;
            NumberOfLegs = 2;
            FavoritePlant = "leaves";
        }

        /// <summary>
        /// Override method - sets Sloth's sweatiness status
        /// </summary>
        /// <returns>string returns animal status</returns>
        public override string Sweat()
        {
            string sweatString = "I'm a sloth and we can't sweat";
            Console.WriteLine(sweatString);
            return sweatString;
        }
    }
}
