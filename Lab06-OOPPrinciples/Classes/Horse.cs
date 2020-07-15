using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Giraffe
    /// Parent - Herbivore
    /// </summary>
    public class Horse : Herbivore
    {
        public int Speed { get; set; }
        public bool Spots { get; set; }

        public Horse(int speed, bool spots, int age, string color)
        {
            Speed = speed;
            Spots = spots;
            Age = age;
            Color = color;
            HasFur = false;
            FavoritePlant = "grass";
            IsGrazer = true;
        }

        public sealed override string Sweat()
        {
            string sweatString = "I'm a horse and we can sweat";
            Console.WriteLine(sweatString);
            return sweatString;
        }
    }
}
