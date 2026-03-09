using System;

namespace BalineseCalendar
{
    public static class Utils
    {
        public static BalineseDate ToBalineseDate(this DateTime dateTime)
        {
            return new BalineseDate(dateTime);
        }
    }
}