using System;
using Sys = Cosmos.System;
using Cosmos.Core;
using Plugs;
using static Cosmos.Core.INTs;

namespace CosmosFlatbinaryExecution
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            SyscallHandler.Init(0x80);

            Console.WriteLine("Starting...");

            byte[] flatbinary = {
                0xcd, 0x80
            };

            MemoryBlock block = new MemoryBlock(0xB00000, (uint)flatbinary.Length * 8);

            block.Write8(flatbinary);

            Plugs.Jumper.Jump();

            Console.WriteLine("If you are seeing this the jump failed.");
        }

        protected override void Run()
        {
            
        }
    }
}