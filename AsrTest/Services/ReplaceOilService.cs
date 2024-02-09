using AsrTest.CashRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.Services
{
    internal class ReplaceOilService : IService
    {
        public Payment paymentOil { get; set; }
        public ReplaceOilService(Payment payment)
        {
            paymentOil = payment;
        }
        public string DoIt(int chosenItemMainMenu)
        {
            Console.WriteLine("Do u want replace oil?");
            int choiceOfReplaceOil = int.Parse(Console.ReadLine());

            switch (choiceOfReplaceOil)
            {
                case 1:
                    string chosenTool = "oil";
                    paymentOil.PayChoice(chosenTool);
                    break;                
                default:
                    Console.WriteLine("incorrect format,try again");
                    break;
            }
            return "";
        }
    }
}
