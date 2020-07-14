using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOPPrinciples.Classes
{
    /// <summary>
    /// Concrete Class for Snake
    /// Parent Class - Reptile
    /// </summary>
    public class Snake : Reptile
    {
        public int Length { get; set; }

        public string PoisonLevel { get; set; }

        public Snake(int length, string poisonLevel, int age, string color)
        {
            Length = length;
            PoisonLevel = poisonLevel;
            NumberOfTeeth = 2;
            Age = age;
            IsVenomous = true;
            Color = color;
        }
    }
}
