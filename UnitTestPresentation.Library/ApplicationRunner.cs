using System;

namespace UnitTestPresentation.Library
{
    public class ApplicationRunner
    {
        public void ShowWelcomeMessage()
        {
            var currentDate = DateTime.Now;
            string message;
            if (currentDate.Month == 12 && (currentDate.Day == 25 || currentDate.Day == 26))
                message = "Frohe Weihnachten!";
            else
                message = "Willkommen!";
            Console.WriteLine(message);
        }
    }
}
