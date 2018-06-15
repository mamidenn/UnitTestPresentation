using System;
using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}