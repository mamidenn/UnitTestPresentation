using System;
using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    public class FakeDateTimeProvider : IDateTimeProvider
    {
        public DateTime DateTime { get; set; } = new DateTime();

        public DateTime GetCurrentDateTime()
        {
            return DateTime;
        }
    }
}