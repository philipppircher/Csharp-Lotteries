using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteries.Classes
{
    class LotteriesTicket
    {
        public int[] TicketNumbers{ get; private set; }
        public int FullNumber { get; private set; }

        public LotteriesTicket(int validDigitLength)
        {
            this.TicketNumbers = EnterNumbers(validDigitLength);
            FullNumber = GetFullNumber();
        }

        private int[] EnterNumbers(int validDigitLength)
        {
            int[] numbers = new int[validDigitLength];

            for (int i = 0; i < validDigitLength; i++)
            {
                Console.WriteLine(i + 1 + ".Ziffer: ");
                numbers[i] = TryParseUserInputToInt();
            }

            Console.WriteLine("Das Lottoticket ist ausgefüllt");
            return numbers;
        }

        private int GetFullNumber()
        {
            string concat = "";

            for (int i = 0; i < TicketNumbers.Length; i++)
            {
                concat += "" + TicketNumbers[i];
            }

            return Int32.Parse(concat);
        }

        private int TryParseUserInputToInt()
        {
            int inputToInt = 0;
            bool isSet = false;

            do
            {
                try
                {
                    string inputAsString = "";

                    do
                    {
                        inputAsString = Console.ReadLine();
                    } while (!IsInputLengthOneDigit(inputAsString));

                    inputToInt = Int32.Parse(inputAsString);
                    isSet = true;
                }
                catch
                {
                    Console.WriteLine("Ungültige Zahleneingabe!\n");
                }
            } while (!isSet);

            return inputToInt;
        }


        private bool IsInputLengthOneDigit(string inputString)
        {
            bool isOneDigit = false;

            if (inputString.Length == 1)
            {
                isOneDigit = true;    
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
                isOneDigit = false;
            }
            return isOneDigit;
        }
    }
}
