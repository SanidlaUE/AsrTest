using AsrTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.CashRegister
{
    internal class CashReceiptArchive : IService
    {
        public List<CashReceipt> myList { get; set; }

        public CashReceiptArchive()
        {
            myList = new List<CashReceipt>();
        }
        public string DoIt(int chosenItemMainMenu)
        {
            if (myList.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("List of cash receipts :");
                foreach (CashReceipt check in myList)
                {
                    Console.WriteLine("" + check);
                }
            }
            return "";
        }
    }
}
