using Ninject;
using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    internal static class Program
    {
        private static void Main()
        {
            var kernel = new StandardKernel(new Binding());
            var dateTimeProvider = kernel.Get<IDateTimeProvider>();
            var outputHandler = kernel.Get<IOutputHandler>();

            var applicationRunner = new ApplicationRunner(dateTimeProvider, outputHandler);
            applicationRunner.ShowWelcomeMessage();
        }
    }
}
