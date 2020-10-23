using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Lotteries.Classes
{
    /// <summary>
    /// Start in Main method and print greeting Message
    /// </summary>
    class LotteriesMenu
    {
        /// <summary>
        /// <para>initalize instances (LotteriesTicket, LotteriesNumber)</para>
        /// Print greeting Message
        /// </summary>
        public static void LotteriesController()
        {
            LotteriesNumber randomNumber = new LotteriesNumber();

            PrintGreeting(randomNumber.ValidLength);
            LotteriesTicket ticket = new LotteriesTicket();
            LotteriesCompare compareTicketWithNumber = new LotteriesCompare(ticket, randomNumber);
        }

        /// <summary>
        /// Prints a greeting Message to console window
        /// </summary>
        private static void PrintGreeting(int digitLength)
        {                                                                                                      
            Console.WriteLine("Willkommen bei der Lotterie");
            Console.WriteLine("Bitte eine " + digitLength + " stellige Zahl eingeben:\n");
        }
    }
}
