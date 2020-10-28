using System;
using System.Collections.Generic;

namespace Lotteries.Classes
{
    /// <summary>
    /// User Ticket with number to enter a length of six digits
    /// </summary>
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

            Console.WriteLine("Das Lottoticket ist ausgefüllt");
        }

        private void TryAddNumberToNumbers(int num) {
            if (IsNumberInNumbersIncluded(num))
            {
                Console.WriteLine("Zahl bereits gewählt\n"); 
            }
            else if (num < this.MaxValue + 1 && num > 0)
            {
                Numbers.Add(num);
                Console.WriteLine("Zahl " + num + " gewählt\n");
            }
            else
            {
                Console.WriteLine("\nZahl liegt nicht zwischen 1 bis 45");
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
                    } while (!IsInputLengthValid(inputAsString));

                    inputToInt = Int32.Parse(inputAsString);
                    isSet = true;
                }
                catch
                {
                    Console.WriteLine("\nUngültige Eingabe, Wert ist keine Zahl!\n");
                }
            } while (!isSet);

            return inputToInt;
        }


        private bool IsInputLengthValid(string inputString)
        {
            bool isDigitLengthValid = false;

            if (inputString.Length > 0 && inputString.Length < 3)
            {
                isDigitLengthValid = true;    
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe, Zahl ist nicht ein bis zwei stellig!\n");
                isDigitLengthValid = false;
            }
            return isDigitLengthValid;
        }
    }
}
