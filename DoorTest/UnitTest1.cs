using System;
using NSubstitute;
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

        [TestCase]
        public void TestDoorOpen()
        {
            _uut.DoorOpened();

            Assert.That(_uut._isDoorOpen, Is.EqualTo(true));
            _door.Received(1).Close();
        }

        [TestCase(12)]
        [TestCase(-1)]
        [TestCase(1200000000)]
        public void RequestEntry_falseid_callEntryNotificationFalseId(int id)
        {
            _uut.RequestEntry(id);
            _entryNotification.Received(1).NotifyEntryDenied(id);
        }

        [TestCase(true,true)]
        [TestCase(false,false)]
        public void RequestEntry_IsValidSetProperly(bool input, bool isValid)
        {
            _userValidation.ValidateEntryRequest(Arg.Any<int>()).Returns(input);
            _uut.RequestEntry(Arg.Any<int>());
            Assert.That(_uut._isValid,Is.EqualTo(isValid));
        }

        [TestCase(true,true)]
        public void DoorClose_Test(bool isDoorOpen, bool isValid)
        {
            _uut._isDoorOpen = isDoorOpen;
            _uut._isValid = isValid;

            _uut.DoorClosed();

            Assert.That(_uut._isDoorOpen,Is.EqualTo(false));
            Assert.That(_uut._isValid,Is.EqualTo(false));
        }
    }
}