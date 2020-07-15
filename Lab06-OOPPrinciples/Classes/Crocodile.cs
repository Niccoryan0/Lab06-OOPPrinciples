using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Crocodiles
    /// Parent - Reptile
    /// </summary>
    public class Crocodile : Reptile
    {
        public string Size { get; set; }

        public bool HasKilledPerson { get; set; }

        public Crocodile(string size, bool hasKilledPerson, int age, string color)
        {
            Size = size;
            HasKilledPerson = hasKilledPerson;
            NumberOfTeeth = 26;
            Age = age;
            Color = color;
        }
    }
}
