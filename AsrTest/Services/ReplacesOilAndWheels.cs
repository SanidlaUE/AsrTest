using AsrTest.CashRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.Services
{
    internal class ReplacesOilAndWheels : IService
    {
        public Payment paymentReplaces { get; set; }
        public ReplacesOilAndWheels(Payment payment)
        {
            paymentReplaces = payment;
        }
        string chosenTool = "";
        public string DoIt(int chosenItemMainMenu)
        {
            int choiceOfReplaceOil = 2;
            int choiceOfReplaceWheels = 3;
            if (chosenItemMainMenu == choiceOfReplaceOil) 
            {
                chosenTool = "oil";
                Console.WriteLine("Do u want replace oil?");
            }
            if(chosenItemMainMenu == choiceOfReplaceWheels)
            {
                chosenTool = "wheel";
                Console.WriteLine("do u want replace wheels?");
            }
            
             int inputReplaceChoise = int.Parse(Console.ReadLine());

            switch (inputReplaceChoise)
            {
                case 1:                    
                    paymentReplaces.PayChoice(chosenTool);
                    break;
                default:
                    Console.WriteLine("incorrect format,try again");
                    break;
            }
            return "";
        }
    }
}
