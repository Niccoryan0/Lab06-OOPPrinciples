using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Abstract Class for Herbivore
    /// Parent Class - Mammal
    /// Derived Classes - Sloth and Giraffe
    /// </summary>
    public abstract class Herbivore : Mammal
    {
        public string FavoritePlant { get; set; }
        public bool IsGrazer { get; set; }
    }
}
