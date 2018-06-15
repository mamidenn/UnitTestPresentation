using System;

namespace UnitTestPresentation.Library
{
    public class ApplicationRunner
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IOutputHandler _outputHandler;

        public ApplicationRunner(IDateTimeProvider dateTimeProvider, IOutputHandler outputHandler)
        {
            _dateTimeProvider = dateTimeProvider;
            _outputHandler = outputHandler;
        }

        public void ShowWelcomeMessage()
        {
            var currentDate = _dateTimeProvider.GetCurrentDateTime();
            string message;
            if (currentDate.Month == 12 && (currentDate.Day == 25 || currentDate.Day == 26))
                message = "Frohe Weihnachten!";
            else
                message = "Willkommen!";
            _outputHandler.WriteLine(message);
        }
    }
}
