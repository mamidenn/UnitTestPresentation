using UnitTestPresentation.Library.Properties;

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
            var message = currentDate.IsChristmas() ? Resources.MerryChristmas : Resources.Welcome;
            _outputHandler.WriteLine(message);
        }
    }
}
