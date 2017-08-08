using System;

namespace Yopon.Common
{
    public class Rand
    {
        private static Random random = new Random();

        public static int om(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}