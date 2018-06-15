using System;

namespace UnitTestPresentation.Library
{
    internal static class DateTimeExtension
    {
        public static bool IsChristmas(this DateTime currentDate)
        {
            return currentDate.Month == 12 && (currentDate.Day == 25 || currentDate.Day == 26);
        }
    }
}