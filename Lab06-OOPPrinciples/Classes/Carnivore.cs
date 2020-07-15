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
        public virtual bool HasKilledPerson { get; set; } = true;

        /// <summary>
        /// Override method - describes sweat properties of carnivores
        /// </summary>
        /// <returns>string setting carnivore sweat type</returns>
        public override string Sweat()
        {
            string sweatString = "Carnivores don't sweat";
            Console.WriteLine(sweatString);
            return sweatString;
        }
    }
}
