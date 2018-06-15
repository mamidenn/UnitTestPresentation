using System;
using UnitTestPresentation.Library;

namespace UnitTestPresentation
{
    public class ConsoleOutputHandler : IOutputHandler
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}