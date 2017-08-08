using System;
using System.Collections.Generic;

namespace Yopon.Pigg.Command
{
    public class MethodLookup
    {
        public Dictionary<int, string> MethodNetwork { get; set; }

        public MethodLookup(Type obj)
        {
            MethodNetwork = new Dictionary<int, string>();

            var fields = obj.GetFields();

            foreach (var field in fields)
            {
                var value = field.GetValue(null);

                if (value is short)
                {
                    MethodNetwork[(short)value] = field.Name;
                }
            }
        }

        public string GetFieldName(int value)
        {
            if (MethodNetwork.ContainsKey(value))
            {
                return MethodNetwork[value];
            }

            return $"Unknown.{value}";
        }
    }
}