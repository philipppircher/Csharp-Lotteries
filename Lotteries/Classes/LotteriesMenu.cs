using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteries.Classes
{
    class LotteriesMenu
    {
        public static void LotteriesController()
        {
            int digitLength = 6;
            LotteriesTicket ticket = GetLotteriesTicket(digitLength);
            LotteriesNumber randomNumber = GetLotteriesNumber(digitLength);
            LotteriesCompare compareTicketWithNumber = new LotteriesCompare(ticket, randomNumber);
        }

        private static void PrintGreeting(int validDigitLength)
        {                                                                                                      
            Console.WriteLine("Willkommen bei der Lotterie");
            Console.WriteLine("Bitte eine " + validDigitLength + " stellige Zahl eingeben: \n");
        }

        private static LotteriesNumber GetLotteriesNumber(int digitLength)
        {
            LotteriesNumber lotteriesNumber = new LotteriesNumber();
            return lotteriesNumber;
        }

        private static LotteriesTicket GetLotteriesTicket(int validDigitLength)
        {
            LotteriesTicket ticket;
           
            PrintGreeting(validDigitLength);
            ticket = new LotteriesTicket();
            return ticket;
        }
    }
}
