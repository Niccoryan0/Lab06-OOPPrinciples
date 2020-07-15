using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Abstract Class for Reptile
    /// Parent Class - Animal
    /// Descendent Classes - Crocodile and Snake
    /// </summary>
    public abstract class Reptile : Animal
    {
        public int NumberOfTeeth { get; set; }

        public virtual bool IsVenomous { get; set; } = false;

        /// <summary>
        /// Virtual method - sets reptile basking patterns
        /// </summary>
        /// <returns>string describing basking status</returns>
        public virtual string Bask()
        {
            string bask = "Baskin' in the sun";
            Console.WriteLine(bask);
            return bask;
        }

        /// <summary>
        /// Override method - Set reptile sleep patterns unique
        /// </summary>
        /// <returns>sleep patterns of reptiles</returns>
        public override string Sleep()
        {
            string reptileSleep = "I sleep when I'm cold because I'm cold blooded";
            Console.WriteLine(reptileSleep);
            return reptileSleep;
        }
    }
}
