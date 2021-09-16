using IL2CPU.API.Attribs;
using XSharp;
using XSharp.Assembler;

namespace Plugs
{
    public static class Jumper
    {
        [PlugMethod(Assembler = typeof(JumpPlug))]
        public static void Jump() => throw null;
    }

    public class JumpPlug : AssemblerMethod
    {
        public override void AssembleNew(Assembler aAssembler, object aMethodInfo)
        {
            XS.Jump("0xB00000");
        }
    }
}