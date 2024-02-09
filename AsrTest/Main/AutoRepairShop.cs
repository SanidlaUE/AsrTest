using AsrTest.CashRegister;
using AsrTest.Exeptions;
using AsrTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.Main
{
    internal class AutoRepairShop
    {
        Payment payment = new Payment();
        ExeptTry exeptTry = new ExeptTry();
        CashReceiptArchive cashReceiptArchive = new CashReceiptArchive();

        private IService oilCheckService;
        public IService OilCheckService
        { get { return oilCheckService; } }


        private IService oilReplaceService;
        public IService OilReplaceService
        { get { return oilReplaceService; } }


        private IService wheelsReplaceService;
        public IService WheelsReplaceService
        { get { return wheelsReplaceService; } }

        private IService replacesOilAndWheels;
        public IService ReplacesOilAndWheels
        { get { return replacesOilAndWheels; } }
        public void Start()
        {
            oilCheckService = new OilCheckService();
            //oilReplaceService = new ReplaceOilService(payment);
            //wheelsReplaceService = new ReplaceWheelService(payment);
            replacesOilAndWheels = new ReplacesOilAndWheels(payment);
            ConsoleInterface();
        }
        public void ConsoleInterface()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Hello,what r u want?\n");
                Console.WriteLine("1. Check oil");
                Console.WriteLine("2. Replace oil");
                Console.WriteLine("3. Replace wheel");
                Console.WriteLine("4. Overview all transactions");
                Console.WriteLine("0. Escape");

                string inputMainMenu = Console.ReadLine();
                exeptTry.TryInput(inputMainMenu);
                int chosenItemMainMenu = int.Parse(exeptTry.tryNewInput);
                string outputSelectionRes = "";

                switch (chosenItemMainMenu)
                {
                    case 1:
                        outputSelectionRes = OilCheckService.DoIt(chosenItemMainMenu); break;
                    case 2:
                        outputSelectionRes = replacesOilAndWheels.DoIt(chosenItemMainMenu); break;
                    //OilReplaceService.DoIt(chosenItemMainMenu); break;
                    case 3:
                        outputSelectionRes = replacesOilAndWheels.DoIt(chosenItemMainMenu); break;
                    //wheelsReplaceService.DoIt(chosenItemMainMenu); break;
                    case 4: outputSelectionRes = cashReceiptArchive.DoIt(chosenItemMainMenu); break;
                    default: Console.WriteLine("Pls push 1 or 2 or 3 or 0"); break;
                }
                Console.WriteLine(outputSelectionRes);

                Console.WriteLine("Escape = 0 or some else button,for console reboot");
            }
            while ((Console.ReadLine() != "0"));
        }
    }
}
