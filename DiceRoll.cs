using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    // Static class created to return data instantly and publicly
    public static class DiceRoll
    {
        //The user can pass in a number, and return a value between 1 and that number
        public static int RollTheDie(int diceSides) //Method if I wrote it like this instead "(this int diceSides)"
        {
            //Random rand = new Random(); // Initialized a new Instance of Random
            //return rand.Next(1, diceSides + 1); //calculations to perform (mini version of a Method)
            return diceSides;
        }
    }
}
