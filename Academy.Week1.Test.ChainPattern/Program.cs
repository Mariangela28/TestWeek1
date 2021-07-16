using Academy.Week1.Test.ChainPattern.Handler;
using System;

namespace Academy.Week1.Test.ChainPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");

            
            IHandler manHandler = new ManagerHandler();
            IHandler operationHandler = new OperationManagerHandler();
            IHandler ceoHandler = new CeoHandler();


            //catena
            manHandler.SetNext(manHandler).SetNext(operationHandler).SetNext(ceoHandler);

            foreach (var item in spesa)
            {
                
                if (item != null)
                {
                    Console.WriteLine($"La spesa {item} ha un importo {manHandler.Handle(item)}");
                }

            }
        }
    }
}
