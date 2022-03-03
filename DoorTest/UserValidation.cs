using NSubstitute;
using System;
using NUnit.Framework;
using SWT_DoorControl;

namespace DoorTest
{
    public class UserValidation
    {
        private IUserValidation _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new SWT_DoorControl.UserValidation();
        }

        [TestCase(-1)]
        [TestCase(11)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MaxValue)]
        public void ValidateEntryRequest_invalidID(int id)
        {
            Assert.That(_uut.ValidateEntryRequest(id), Is.False);
        }
        [TestCase(0)]
        [TestCase(10)]
        public void ValidateEntryRequest_ValidID(int id)
        {
            Assert.That(_uut.ValidateEntryRequest(id), Is.True);
        }

    }
}