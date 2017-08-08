using Yopon.Pigg;
using SwfDec;
using SwfDec.AVM2.ByteCode;
using SwfDec.AVM2.ByteCode.Instructions;
using SwfDec.AVM2.ByteCode.Instructions.Push;
using SwfDec.AVM2.ByteCode.Instructions.Return;
using SwfDec.AVM2.Types;
using SwfDec.AVM2.Types.Traits;
using System.Collections.Generic;

namespace Yopon.Flash
{
    public class DefacingAbc
    {
        public static byte[] EditHost(byte[] raw, int localPort)
        {
            var swf = new Swf();

            swf.Decompile(raw);

            foreach (var doAbcTag in swf.DoAbcTagList)
            {
                var abc = doAbcTag.AbcData;
                var constantPool = abc.ConstantPool;
                var localServer = $"info@{ProductConfiguration.LocalIP}";

                foreach (var instance in abc.InstanceArray)
                {
                    var className = instance.Name.MKQName.Name;
                    var nameSpace = instance.ProtectedNamespace?.Name?.String;
                    var traits = instance.TraitArray.GetTraits();

                    if (nameSpace != "ProductConfiguration")
                        continue;

                    foreach (var trait in traits)
                    {
                        var memberName = trait.Name.MKQName.Name;

                        if (memberName == "infoHost")
                        {
                            var method = ((TraitGetter)trait.Trait).Method;
                            var bin = method.MethodBody.Code;
                            var byteCode = new ByteCode(bin, abc);

                            var instructions = new List<As3Instruction>();
                            var index = constantPool.StringArrayLength;
                            var stringInfo = new StringInfo(index, localServer);

                            constantPool.SetStringAt(stringInfo, index);

                            instructions.Add(new As3PushString(index));
                            instructions.Add(new As3ReturnValue());

                            var count = 0;

                            foreach (var instruction in instructions)
                                byteCode.AddInstructionAt(instruction, count++);

                            while (byteCode.GetInstructions().Count > count)
                                byteCode.RemoveInstructionAt(count - 1);

                            method.MethodBody.Code = byteCode.GetBytes();
                        }
                        else if (memberName == "infoWebSocketPort")
                        {
                            var method = ((TraitGetter)trait.Trait).Method;
                            var bin = method.MethodBody.Code;
                            var byteCode = new ByteCode(bin, abc);
                            var instructions = byteCode.GetInstructions();

                            for (var count = 0; count < instructions.Count; count++)
                            {
                                if (instructions[count] is As3PushShort port
                                    && 443 == port.Short)
                                {
                                    var index = constantPool.IntArrayLength;
                                    constantPool.SetIntAt(localPort, index);
                                    instructions[count] = new As3PushInt(index);
                                }
                            }

                            method.MethodBody.Code = byteCode.GetBytes();
                        }
                    }
                }
            }

            return swf.Compile();
        }
    }
}