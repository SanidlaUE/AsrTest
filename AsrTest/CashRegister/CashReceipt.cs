using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.CashRegister
{
    internal class CashReceipt
    {
        private string recOperationName;
        private int recOperationValue;
        private int recOverpaymentValue;
        public CashReceipt(string OperationName, int OperationValue, int OverpaymentValue)
        {
            this.recOperationName = OperationName;
            this.recOperationValue = OperationValue;
            this.recOverpaymentValue = OverpaymentValue;
        }

        public override bool Equals(object? obj)
        {
            return obj is CashReceipt check &&
                   recOperationName == check.recOperationName &&
                   recOperationValue == check.recOperationValue &&
                   recOverpaymentValue == check.recOverpaymentValue;
        }

        public override string ToString()
        {
            return "CashReceipt:" + "\t1. Tool name: " + recOperationName + "\t2.Price of tool: " + recOperationValue + "\t3. Overpayment(optional): " + recOverpaymentValue;
        }
    }
}
