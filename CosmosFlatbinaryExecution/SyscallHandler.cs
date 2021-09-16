using System;
using static Cosmos.Core.INTs;

namespace CosmosFlatbinaryExecution
{
    class SyscallHandler
    {
        static byte interrupt;
        public static void Init(byte interrupt)
        {
            Console.WriteLine("Setting up syscalls...");
            SyscallHandler.interrupt = interrupt;
            SetIntHandler(interrupt, InterruptHandler);
            Console.WriteLine("Syscalls Setup.");
        }
        public static void InterruptHandler(ref IRQContext aContext)
        {
            Console.WriteLine("syscall");

            //if (aContext.Interrupt != interrupt) return;
            /*switch (aContext.EAX)
            {
                case 0x1:
                    Console.WriteLine("interrupt");
                    break;
            }*/
        }
    }
}
