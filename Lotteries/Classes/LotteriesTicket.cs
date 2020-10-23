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
            int counter = 0;
            do
            {
                Console.WriteLine(counter + 1 + ".Ziffer: ");

                num = TryParseUserInputToInt();

                  if (IsNumberInNumbersIncluded(num))
                  {
                        Console.WriteLine("Zahl bereits gewählt\n");
                  }
                  else
                  {
                        Numbers.Add(num);
                        Console.WriteLine("Zahl " + num + " gewählt\n");
                        counter++;
                  }
            } while (counter < ValidLength);

            this.FullNumber = GetFullNumber();
            Console.WriteLine("Das Lottoticket ist ausgefüllt");
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
