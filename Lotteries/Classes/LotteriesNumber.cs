using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteries.Classes
{
    class LotteriesNumber
    {
        public int[] RandomNumbers { get; private set; }
        public int FullNumber { get; private set; }

        public LotteriesNumber(int validDigitLength)
        {
            CreateRandomNumbers(validDigitLength);
            FullNumber = GetFullNumber();
        }

        private int GetFullNumber()
        {
            string concat = "";

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                concat += "" + RandomNumbers[i];
            }

            return Int32.Parse(concat);
        }

        private void CreateRandomNumbers(int validDigitLength)
        {
            Random random = new Random();
            RandomNumbers = new int[validDigitLength];

            for (int i = 0; i < validDigitLength; i++)
            {
                RandomNumbers[i] = random.Next(9) + 1;
            }
        }
    }
}