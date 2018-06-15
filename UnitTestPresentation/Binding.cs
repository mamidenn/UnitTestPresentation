using Ninject.Modules;
using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IDateTimeProvider>().To<DateTimeProvider>();
            Bind<IOutputHandler>().To<ConsoleOutputHandler>();
        }
    }
}