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

        public bool IsVenomous { get; set; }
    }
}
