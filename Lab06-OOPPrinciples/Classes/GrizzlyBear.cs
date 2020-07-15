using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Grizzly Bear
    /// Parent - Carnivore
    /// </summary>
    public class GrizzlyBear : Carnivore
    {
        public bool IsFerocious { get; set; }
        public int Weight { get; set; }

        public GrizzlyBear(bool isFerocious, int weight, int age, string color, bool hasKilledPerson)
        {
            IsFerocious = isFerocious;
            Weight = weight;
            Age = age;
            Color = color;
            FavoriteMeat = "salmon";
            HasKilledPerson = hasKilledPerson;
        }
    }
}
