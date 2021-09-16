using IL2CPU.API.Attribs;
using XSharp;
using XSharp.Assembler;

namespace Plugs
{
    public static class Jumper
    {
        [PlugMethod(Assembler = typeof(CallerPlug))]
        public static void Jump() => throw null;
    }

    public class CallerPlug : AssemblerMethod
    {
        public override void AssembleNew(Assembler aAssembler, object aMethodInfo)
        {
            XS.Jump("0xB00000");
        }
    }
}