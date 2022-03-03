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
        private IDoor _uut;

        [SetUp]
        public void Setup()
        {
            _doorControl = Substitute.For<IDoorControl>();
            _uut = new Door(_doorControl);
        }

        [Test]
        public void TestOpen()
        {
            _uut.Open();
            
                _doorControl.Received(1).DoorOpened();
        }

        [Test]
        public void TestClose()
        {
            _uut.Close();

            _doorControl.Received(1).DoorClosed();


        }









    }
}
