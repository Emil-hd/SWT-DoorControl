using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;
using SWT_DoorControl;

namespace DoorTest
{
    class DoorClassTestClass
    {

        private IDoorControl _doorControl;
        private IUserValidation _userValidation;
        private IDoor _uut;
        private IEntryNotification _entryNotification;

        [SetUp]
        public void Setup()
        {
            _userValidation = Substitute.For<IUserValidation>();
            _doorControl = Substitute.For<IDoorControl>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _uut = new Door();
        }

        [Test]
        public void TestOpen()
        {
            Assert.Pass();
        }

        public void TestClose()
        {
            Assert.Pass();
        }

        public void TestOpen()
        {
            Assert.Pass();
        }

        public void TestOpen()
        {
            Assert.Pass();
        }







    }
}
