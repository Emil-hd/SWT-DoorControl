using NSubstitute;
using NSubstitute.Core.Arguments;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;
using SWT_DoorControl;

namespace DoorTest
{
    public class Tests
    {
        private IDoorControl _uut;
        private IUserValidation _userValidation;
        private IDoor _door;
        private IEntryNotification _entryNotification;

        [SetUp]
        public void Setup()
        {
            _userValidation = Substitute.For<IUserValidation>();
            _door = Substitute.For<IDoor>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _uut = new DoorControl(_door, _entryNotification, _userValidation);
        }

        [TestCase(11)]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void RequestEntry_FalseId_CallEntryNotificationFalseId(int id)
        {
            _userValidation.ValidateEntryRequest(Arg.Any<int>()).Returns(false);
            _uut.RequestEntry(id);
            _entryNotification.Received(1).NotifyEntryDenied(id);
        }
        [TestCase(11)]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void RequestEntry_FalseId_IsValidFalse(int id)
        {
            _userValidation.ValidateEntryRequest(Arg.Any<int>()).Returns(false);
            _uut.RequestEntry(id);
            Assert.That(_uut._isValid,Is.False);
        }
        [TestCase(10)]
        [TestCase(0)]
        public void RequestEntry_TrueId_CallEntryNotificationTrueId(int id)
        {
            _userValidation.ValidateEntryRequest(Arg.Any<int>()).Returns(true);
            _uut.RequestEntry(id);
            _entryNotification.Received(1).NotifyEntryGranted(id);
        }
        [TestCase(10)]
        [TestCase(0)]
        public void RequestEntry_TrueId_IsValidTrue(int id)
        {
            _userValidation.ValidateEntryRequest(Arg.Any<int>()).Returns(true);
            _uut.RequestEntry(id);
            Assert.That(_uut._isValid, Is.True);
        }
    }
}