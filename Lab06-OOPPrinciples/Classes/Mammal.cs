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
        public virtual bool HasFur { get; set; } = true;
        public virtual int NumberOfLegs { get; set; } = 4;

        /// <summary>
        /// Method to describe if the animal can sweat
        /// </summary>
        /// <returns>Sweat string</returns>
        public abstract string Sweat();

        /// <summary>
        /// Override method - describing sleep patterns of mammals
        /// </summary>
        /// <returns>string - mammal sleep</returns>
        public override string Sleep()
        {
            string mammalSleep = "I sleep when I'm tired because I'm warm blooded";
            Console.WriteLine(mammalSleep);
            return mammalSleep;
        }
    }
}
