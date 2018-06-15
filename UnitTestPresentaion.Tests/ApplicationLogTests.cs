using NUnit.Framework;
using UnitTestPresentation.Library;

namespace UnitTestPresentation.Tests
{
    [TestFixture]
    public class ApplicationLogTests
    {
        [Test]
        [TestCase("filename.log")]
        [TestCase("syslog.log")]
        [TestCase("logfile.log")]
        public void IsValidFileName_ValidFileName_ReturnTrue(string filename)
        {
            // Arrange
            var applicationLog = new ApplicationLog();

            // Act
            var isValidFilename = applicationLog.IsValidFilename(filename);

            // Assert
            Assert.IsTrue(isValidFilename);
        }

        [Test]
        public void IsValidFilename_NullValue_ReturnFalse()
        {
            var isValidFilename = new ApplicationLog().IsValidFilename(null);
            Assert.IsFalse(isValidFilename);
        }

        [Test]
        public void IsValidFilename_EmptyString_ReturnFalse()
        {
            var isValidFilename = new ApplicationLog().IsValidFilename(string.Empty);
            Assert.IsFalse(isValidFilename);
        }

        [Test]
        public void IsValidFilename_TooShort_ReturnFalse()
        {
            var isValidFilename = new ApplicationLog().IsValidFilename(".log");
            Assert.IsFalse(isValidFilename);
        }

        [Test]
        [TestCase("filename.txt")]
        [TestCase("filename.pdf")]
        [TestCase("filename.md")]
        public void IsValidFilename_InvalidExtension_ReturnFalse(string filename)
        {
            var isValidFilename = new ApplicationLog().IsValidFilename(filename);
            Assert.IsFalse(isValidFilename);
        }
    }
}
