using System;
using Sys = Cosmos.System;
using Cosmos.Core;
using Plugs;

namespace CosmosFlatbinaryExecution
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Starting...");

            byte[] flatbinary = {
                0xcd, 0x80
            };

            MemoryBlock block = new MemoryBlock(0xB00000, (uint)flatbinary.Length);

            block.Write8(flatbinary);

            Plugs.Jumper.Jump();
        }

        protected override void Run()
        {
            
        }
    }
}