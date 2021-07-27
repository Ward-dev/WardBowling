using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardBowling
{
    class Game
    {
        private int[] frame = new int[10];
        private int[] throws = new int[20];
        int currentThrow = 0;

        public bool Strike(int throwNumber)
        {
            return throws[throwNumber] == 10;
        }

        public bool Spare(int throwNumber)
        {
            return throws[throwNumber] + throws[throwNumber + 1] == 10;
        }

        public void Throw(int amountOfPins) 
        {
            throws[currentThrow] = amountOfPins;
        }


    }
}
