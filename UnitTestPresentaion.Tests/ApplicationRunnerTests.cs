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

        private static DateTime[] _christmasDates =
        {
            new DateTime(2018, 12, 25),
            new DateTime(2018, 12, 26)
        };

        private static DateTime[] _standardDates =
        {
            new DateTime(2018, 12, 24),
            new DateTime(1592, 3, 14),
            new DateTime(1977, 5, 25)
        };

        [SetUp]
        public void SetUp()
        {
            _dateTimeProviderStub = Substitute.For<IDateTimeProvider>();
            _outputHandlerMock = Substitute.For<IOutputHandler>();
        }

        [Test]
        public void ShowWelcomeMessage_ItsChristmas_ShowChristmasMessage(
            [ValueSource(nameof(_christmasDates))] DateTime date)
        {
            // Arrange
            _dateTimeProviderStub.GetCurrentDateTime().Returns(date);

            // Act
            new ApplicationRunner(_dateTimeProviderStub, _outputHandlerMock).ShowWelcomeMessage();

            // Assert
            _outputHandlerMock.Received(1).WriteLine("Frohe Weihnachten!");
        }

        [Test]
        public void ShowWelcomeMessage_ItsNotChristmas_ShowDefaultMessage(
            [ValueSource(nameof(_standardDates))] DateTime date)
        {
            // Arrange
            _dateTimeProviderStub.GetCurrentDateTime().Returns(date);

            // Act
            new ApplicationRunner(_dateTimeProviderStub, _outputHandlerMock).ShowWelcomeMessage();

            // Assert
            _outputHandlerMock.Received(1).WriteLine("Willkommen!");
        }
    }
}