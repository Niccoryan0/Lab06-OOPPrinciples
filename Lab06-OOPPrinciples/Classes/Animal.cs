using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    public class Animal
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public bool ToggleSleep(bool isAwake)
        {
            if (isAwake)
            {
                isAwake = false;
            }
            else
            {
                isAwake = true;
            }
            return isAwake;
        }
    }
}
