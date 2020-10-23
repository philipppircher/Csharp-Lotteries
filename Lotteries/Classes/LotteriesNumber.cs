using System;

namespace Lotteries.Classes
{
    class LotteriesNumber : LotteriesClass
    { 
        public LotteriesNumber()
        {
            CreateRandomNumbers();
        }

        private void CreateRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < ValidLength; i++)
            {
                int rand;

                do {
                    rand = random.Next(9) + 1;
                } while (IsNumberInNumbersIncluded(rand)) ;
                Numbers.Add(rand);
            }   

            FullNumber = GetFullNumber();
        }
    }
}