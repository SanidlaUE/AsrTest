using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.Exeptions
{
    internal class ExeptTry
    {
        public string tryNewInput;
        public string TryInput(string inputFromConsole)
        {
            if (string.IsNullOrEmpty(inputFromConsole) || !inputFromConsole.All(c => c == '0' || c == '1' || c == '2' || c == '3' || c == '4'))
            {
                do
                {
                    Console.WriteLine("Input character from list");
                    tryNewInput = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(tryNewInput) || !tryNewInput.All(c => c == '0' || c == '1' || c == '2' || c == '3' || c == '4'));
            }
            else tryNewInput = inputFromConsole;
            return tryNewInput;

        }
    }
}

