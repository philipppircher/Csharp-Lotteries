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

        public int ValidLength { get; private set; }

        public int MaxValue { get; private set; }

        protected LotteriesClass()
        {
            Numbers = new List<int>();
            ValidLength = 6;
            MaxValue = 45;
        }

        protected int GetFullNumberAsIntArray()
        {
            int[] element = new int[ValidLength];

            for (int i = 0; i < ValidLength; i++)
            {
                element[i] = Numbers.ElementAt(i);
            }

            return Int32.Parse(this.ToString());
        }

        protected bool IsNumberInNumbersIncluded(int number)
        {
            return Numbers.Contains(number);
        }

        public override string ToString()
        {
            string concat = "";

            for (int i = 0; i < ValidLength; i++)
            {
                concat += "" + Numbers.ElementAt(i) + ", ";
            }

            return concat;
        }
    }
}
