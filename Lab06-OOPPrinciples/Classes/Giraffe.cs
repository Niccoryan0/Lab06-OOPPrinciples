using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Giraffe
    /// Parent - Herbivore
    /// </summary>
    public class Giraffe : Herbivore
    {
        public int NeckLength { get; set; }
        public bool Spots { get; set; }

        public Giraffe(int neckLength, bool spots, int age, string color)
        {
            NeckLength = neckLength;
            Spots = spots;
            Age = age;
            Color = color;
            NumberOfLegs = 4;
            HasFur = false;
            FavoritePlant = "grass";
            IsGrazer = true;
        }
    }
}
