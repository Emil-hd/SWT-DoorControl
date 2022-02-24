using NSubstitute;
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

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}