using System;

namespace Lotteries.Classes
{
    class LotteriesCompare
    {
        private LotteriesTicket lotteriesTicket;
        private LotteriesNumber lotteriesNumber;
        private int matchingNumbers = 0;

        public LotteriesCompare(LotteriesTicket lotteriesTicket, LotteriesNumber lotteriesNumber)
        {
            this.lotteriesTicket = lotteriesTicket;
            this.lotteriesNumber = lotteriesNumber;
            PrintTicketWithRandomNumberComparison();
        }

        private void PrintTicketWithRandomNumberComparison()
        {
            int matchingNumbers = 0;
            Console.WriteLine("Ticket\t" + "|" + "\tLotterie" + "|" + "\tTreffer");
            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < lotteriesNumber.ValidLength; i++)
            {
                bool match = false;

                if (lotteriesNumber.Numbers[i] == lotteriesTicket.Numbers[i])
                {
                    match = true;
                    matchingNumbers++;
                }

                Console.Write(lotteriesTicket.Numbers[i] + "\t" + "|" + "\t" + lotteriesNumber.Numbers[i] +
                    "\t" + "|" + "\t" + match +"\n");
            }

            PrintMatchingNumbersWithResult(matchingNumbers);
        }

        private void PrintMatchingNumbersWithResult(int matchingNumbers)
        {
            if (matchingNumbers > 0)
            {
                Console.WriteLine("Du hast " + matchingNumbers + " Treffer gelandet");
            }
            else
            {
                Console.WriteLine("Du hast keine Treffer gelandet");
            }

            Console.WriteLine("Deine Ticket eingabe:\t " + lotteriesTicket.FullNumber);
            Console.WriteLine("Gewinnspielnummer:\t " + lotteriesNumber.FullNumber);
        }
    }
}
