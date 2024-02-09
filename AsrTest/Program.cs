using AsrTest.Main;
using AsrTest.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        AutoRepairShop autoRepairShop = new AutoRepairShop(new OilCheckService());
        autoRepairShop.Start();
        //TODO
        // клинить консоль 

        // сделать лист в архиве паблик и напрямую обращаться в архив из аср
        //вынести вывод "replaced" в сервис replacedoilwheels
        //try catch


        //*авторизация,список клиентов 
    }
}