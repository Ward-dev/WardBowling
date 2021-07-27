using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardBowling
{
   public class Game
    {
        private int[] frame = new int[10];
        private int[] throws = new int[21];
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
            currentThrow++;
        }

        public int CalculateTotalScore()
        {
            int throwNumber = 0;
            int score = 0;

            //Iterate through all 10 frames
            for (int i = 0; i < 10; i++)
            {
                if (Strike(throwNumber))
                {
                    
                    score += 10 + throws[throwNumber + 1] + throws[throwNumber + 2];
                    throwNumber++;
                }
                else if (Spare(throwNumber))
                {
                    score += 10 + throws[throwNumber + 2];
                    throwNumber += 2;
                }
                else
                {
                    score += throws[throwNumber] + throws[throwNumber + 1];
                    throwNumber += 2;
                }
            }

            return score;
        }


    }
}
