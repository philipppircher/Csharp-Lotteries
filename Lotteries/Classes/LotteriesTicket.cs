using System;
using System.Collections.Generic;

namespace Lotteries.Classes
{
    class LotteriesTicket : LotteriesClass
    {
        public LotteriesTicket()
        {
            EnterNumbers();
        }

        private void EnterNumbers()
        {
            int num;

            do
            {
                Console.WriteLine((Numbers.Count + 1) + ".Ziffer: ");

                num = TryParseUserInputToInt();
                TryAddNumberToNumbers(num);

            } while (Numbers.Count < ValidLength);

            this.FullNumber = GetFullNumber();
            Console.WriteLine("Das Lottoticket ist ausgefüllt");
        }


        private void TryAddNumberToNumbers(int num) {
            if (IsNumberInNumbersIncluded(num))
            {
                Console.WriteLine("Zahl bereits gewählt\n", Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Red); 
            }
            else
            {
                Numbers.Add(num);
                Console.WriteLine("Zahl " + num + " gewählt\n");
            }
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
