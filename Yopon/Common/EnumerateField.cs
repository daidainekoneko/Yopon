using System.Collections.Generic;

namespace Yopon.Common
{
    public class EnumerateField
    {
        private Dictionary<int, string> CommandNetwork = new Dictionary<int, string>();

        public EnumerateField(object obj)
        {
            var fields = obj.GetType().GetFields();

            foreach (var field in fields)
            {
                var value = field.GetValue(obj);

                if (value is short)
                {
                    CommandNetwork[(short)value] = field.Name;
                }
            }
        }

        public string GetFieldName(int value)
        {
            if (CommandNetwork.ContainsKey(value))
            {
                return CommandNetwork[value];
            }

            return $"Undefined.{value}";
        }
    }
}