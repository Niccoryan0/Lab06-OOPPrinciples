using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{

    /// <summary>
    /// Animal Abstract Parent Class 
    /// </summary>

    public abstract class Animal
    {
        public int Age { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Abstract Method - Describe animal sleep behavior
        /// </summary>
        public abstract string Sleep();

        /// <summary>
        /// Virtual method - Sets all animals breathing status
        /// </summary>
        /// <returns>string returns breathing status of all animals</returns>
        public virtual string Breathe()
        {
            string breathes = "Breathe in, breathe out";
            Console.WriteLine(breathes);
            return breathes;
        }
    }
}
