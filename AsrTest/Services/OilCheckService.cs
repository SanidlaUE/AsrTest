﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrTest.Services
{
    internal class OilCheckService : IService
    {
        public string DoIt(int chosenItemMainMenu)
        {
            do
            {
                Console.WriteLine("do you want to check the oil? 1 - yes or any key for reboot menu");
                int choiceOfOilCheckS = int.Parse(Console.ReadLine());
                string outputOfOilCheckRes = "";
                switch (choiceOfOilCheckS)
                {
                    case 1:
                        Random random = new Random();
                        int r = random.Next(0, 2);
                        if (r == 0) outputOfOilCheckRes = "u need replace oil";
                        else outputOfOilCheckRes = "Oil is ok";
                        return outputOfOilCheckRes;
                    case 2: return outputOfOilCheckRes;
                    default:
                        Console.WriteLine("Pls push 1 or 2"); break;
                }
            }
            while ((Console.ReadLine() != "2"));           
            return "ok";
        }

    }
}
