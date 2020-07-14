using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Abstract Class for Carnivores
    /// Parent - Mammal 
    /// Derived - Lion and Grizzly Bear
    /// </summary>
    public abstract class Carnivore : Mammal
    {
        public string FavoriteMeat { get; set; }
        public bool HasKilledPerson { get; set; }
    }
}
