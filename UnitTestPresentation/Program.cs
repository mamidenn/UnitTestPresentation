using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    internal static class Program
    {
        private static void Main()
        {
            var applicationRunner = new ApplicationRunner(new DateTimeProvider(), new ConsoleOutputHandler());
            applicationRunner.ShowWelcomeMessage();
        }
    }
}
