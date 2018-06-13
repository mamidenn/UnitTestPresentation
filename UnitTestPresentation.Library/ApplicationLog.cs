namespace UnitTestPresentation.Library
{
    public class ApplicationLog
    {
        public bool IsValidFilename(string filename)
        {
            var isValidFilename = !string.IsNullOrWhiteSpace(filename)
                                  && filename.Length > 4
                                  && filename.EndsWith(".log");
            return isValidFilename;
        }
    }
}