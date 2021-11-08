using System;

namespace MyCoin.Utils
{
    public static class BinanceHelper
    {
        public static DateTime DateConverter(long tick)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return epoch.AddMilliseconds(tick).ToLocalTime();
        }
    }
}