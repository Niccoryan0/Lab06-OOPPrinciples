using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Lion
    /// Parent Class - Carnivore
    /// </summary>
    public class Lion : Carnivore
    {
        public bool HasMane { get; set; }
        public int PrideSize { get; set; }

        public Lion(bool hasMane, int prideSize, int age, string color, bool hasKilledPerson)
        {
            HasMane = hasMane;
            PrideSize = prideSize;
            Age = age;
            Color = color;
            HasFur = true;
            NumberOfLegs = 4;
            FavoriteMeat = "zebra";
            HasKilledPerson = hasKilledPerson;
        }
    }
}
