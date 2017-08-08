using SwfDec;
using System.Collections.Generic;

namespace Yopon.Pigg
{
    public class AllowActionList
    {
        private static HashSet<string> permitList = new HashSet<string>();

        private static HashSet<string> blockList = new HashSet<string>()
        {
            "ufo_event_secret"
        };

        public static void LoadSwf(byte[] module)
        {
            var swf = new Swf();

            swf.Decompile(module);

            foreach (var doAbcTag in swf.DoAbcTagList)
            {
                var abc = doAbcTag.AbcData;
                var constantPool = abc.ConstantPool;
                var strlen = constantPool.StringArrayLength;

                for (var index = 0u; index < strlen; index++)
                {
                    var constantStr = constantPool
                        .GetStringAt(index)?.String;

                    if (!string.IsNullOrEmpty(constantStr) &&
                        constantStr.ToLower() is var i &&
                        i.EndsWith("_secret") && Add(i))
                    {
                        if (YoponSetting.I.IsDebugMode)
                        {
                            Logger.OutputAtBackground(
                                YoponSetting.DebugLogFile,
                                $"[DEBUG] アクション追加 ({i})");
                        }
                    }
                }
            }
        }

        public static bool Add(string actionCode)
        {
            return permitList.Add(actionCode);
        }

        public static bool IsFraud(string code)
        {
            if (IsYopon(code))
                return false;
            if (!IsSecret(code))
                return false;
            if (code.Contains("\0"))
                return true;
            if (blockList.Contains(code))
                return true;
            if (!permitList.Contains(code))
                return true;

            return false;
        }

        public static bool IsYopon(string actionCode)
        {
            return actionCode.Contains("$in");
        }

        public static bool IsSecret(string actionCode)
        {
            return actionCode.EndsWith("_secret");
        }

        public static string GetYoponAction(string code)
        {
            return $"{code}\0_$in_secret";
        }
    }
}