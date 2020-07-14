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
        /// Method - Set animal status: sleeping or awake
        /// </summary>
        /// <param name="isAwake">Is the animal awake?</param>
        /// <returns>Whether or not the animal is awake</returns>
        public bool ToggleSleep(bool isAwake)
        {
            if (isAwake)
            {
                Console.WriteLine("I'm going to sleep");
                isAwake = false;
            }
            else
            {
                Console.WriteLine("I'm waking up");
                isAwake = true;
            }
            return isAwake;
        }
    }
}
