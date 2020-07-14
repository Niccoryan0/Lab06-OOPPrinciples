using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Abstract Class for Mammal
    /// Parent Class - Animal
    /// Derived Classes - Carnivore and Herbivore
    /// </summary>
    public abstract class Mammal : Animal
    {
        public bool HasFur { get; set; }
        public int NumberOfLegs { get; set; }

        /// <summary>
        /// Method to describe if the animal can sweat
        /// </summary>
        /// <returns>Sweat string</returns>
        public string Sweat()
        {
            string sweatString = "I am sweaty";
            Console.WriteLine(sweatString);
            return sweatString;
        }
    }
}
