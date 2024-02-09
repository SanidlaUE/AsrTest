using AsrTest.CashRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.Services
{
    internal class ReplaceWheelService : IService
    {
        public Payment paymentWheels { get; set; }
        public ReplaceWheelService(Payment payment)
        {
            paymentWheels = payment;
        }
        public string DoIt(int chosenItemMainMenu)
        {
            Console.WriteLine("do u want replace wheels?");
            int choiceOfReplaceWheels = int.Parse(Console.ReadLine());

            switch (choiceOfReplaceWheels)
            {
                case 1:
                    string chosenTool = "wheel";
                    paymentWheels.PayChoice(chosenTool);
                    break;
                default:
                    Console.WriteLine("incorrect format,try again");
                    break;
            }
            return "";
        }
    }
}