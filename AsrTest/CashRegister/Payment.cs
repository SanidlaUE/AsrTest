using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsrTest.CashRegister
{
    internal class Payment
    {
        private int priceReplaceWheels = 300;
        private int priceReplaceOil = 200;
        private int inputCash;        


        public void PayChoice(string chosenTool)
        {
            int chosenToolPrice;
            switch (chosenTool)
            {
                case "wheel":
                    PayReplace(priceReplaceWheels, chosenTool);
                    break;
                case "oil":
                    PayReplace(priceReplaceOil, chosenTool);
                    break;
            }
        }
        public void PayReplace(int chosenToolPrice, string chosenTool)
        {
            int overpayment = 0;
            Console.WriteLine("it cost {0},input money", chosenToolPrice);
            inputCash = int.Parse(Console.ReadLine());

            int priceDifference = chosenToolPrice - inputCash;

            if (priceDifference < 0)
            {
                overpayment = priceDifference * -1;
                Console.WriteLine("ur overpayment money {0}", overpayment);
                Console.WriteLine("{0} replaced\n", chosenTool);
            }
            else if (priceDifference > 0)
            {
                do
                {
                    Console.WriteLine("not enough {0},input more money pls", priceDifference);
                    inputCash = int.Parse(Console.ReadLine());
                    priceDifference -= inputCash;
                    if (priceDifference < 0)
                    {
                        Console.WriteLine("ur overpayment money {0}", priceDifference * -1);
                        overpayment = priceDifference * -1;
                        priceDifference = 0;
                    }
                } while (priceDifference != 0);
                if (inputCash > chosenToolPrice)
                {
                    overpayment = inputCash - chosenToolPrice;
                    Console.WriteLine("ur overpayment money {0}", overpayment);
                }
                Console.WriteLine("{0} replaced\n", chosenTool);

            }
            else { Console.WriteLine("{0} replaced\n", chosenTool); }
            SaveCashReceipt(chosenTool, chosenToolPrice, overpayment);
        }       
        public void SaveCashReceipt(string chosenTool, int chosenToolPrice, int overpayment)
        {
               myList.Add(new CashReceipt(chosenTool, chosenToolPrice, overpayment));
        }        
    }
}


