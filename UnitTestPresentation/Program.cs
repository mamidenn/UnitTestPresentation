using Ninject;
using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    internal static class Program
    {
        private static void Main()
        {
            var kernel = new StandardKernel(new Binding());
            var applicationRunner = kernel.Get<ApplicationRunner>();
            applicationRunner.ShowWelcomeMessage();
        }
    }
}
