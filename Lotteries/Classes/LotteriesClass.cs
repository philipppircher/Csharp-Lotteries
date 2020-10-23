using System;
using System.Collections.Generic;
using System.Linq;

namespace Lotteries.Classes
{
    /// <summary>
    /// LotterisClass is Superclass of LotterisNumber and LotteriesTicket
    /// </summary>
    class LotteriesClass
    {
        public List<int> Numbers { get; set; }
        public int FullNumber { get; protected set; }

        public int ValidLength { get; private set; }

        protected LotteriesClass()
        {
            Numbers = new List<int>();
            ValidLength = 6;
        }
        protected int GetFullNumber()
        {
            string concat = "";

            for (int i = 0; i < ValidLength; i++)
            {
                concat += "" + Numbers.ElementAt(i);
            }

            return Int32.Parse(concat);
        }

        protected bool IsNumberInNumbersIncluded(int number)
        {
            return Numbers.Contains(number);
        }
    }
}
