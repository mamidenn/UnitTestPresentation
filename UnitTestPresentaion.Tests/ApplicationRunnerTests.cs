using System;
using NSubstitute;
using NUnit.Framework;
using UnitTestPresentation.Library;

namespace UnitTestPresentation.Tests
{
    [TestFixture]
    public class ApplicationRunnerTests
    {
        private IDateTimeProvider _dateTimeProviderStub;
        private IOutputHandler _outputHandlerMock;

        [SetUp]
        public void SetUp()
        {
            _dateTimeProviderStub = Substitute.For<IDateTimeProvider>();
            _outputHandlerMock = Substitute.For<IOutputHandler>();
        }

        [Test]
        public void ShowWelcomeMessage_ItsChristmas_ShowChristmasMessage()
        {
            // Arrange
            _dateTimeProviderStub.GetCurrentDateTime().Returns(new DateTime(2018, 12, 25));

            // Act
            new ApplicationRunner(_dateTimeProviderStub, _outputHandlerMock).ShowWelcomeMessage();

            // Assert
            _outputHandlerMock.Received(1).WriteLine("Frohe Weihnachten!");
        }

        [Test]
        public void ShowWelcomeMessage_ItsNotChristmas_ShowDefaultMessage()
        {
            // Arrange
            _dateTimeProviderStub.GetCurrentDateTime().Returns(new DateTime(2018, 12, 24));

            // Act
            new ApplicationRunner(_dateTimeProviderStub, _outputHandlerMock).ShowWelcomeMessage();

            // Assert
            _outputHandlerMock.Received(1).WriteLine("Willkommen!");
        }
    }
}