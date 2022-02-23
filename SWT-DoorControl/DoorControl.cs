using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    class DoorControl
    {
        public Door _door { get; set; }
        public EntryNotification _entryNotification { get; set; }
        public UserValidation _userValidation { get; set; }
        public bool _isValid { get; set; }
        public DoorControl(Door door, EntryNotification entryNotification, UserValidation userValidation)
        {
            _door = door;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
            _isValid = false;
        }
        public void RequestEntry(int id)
        {
            _isValid=_userValidation.ValidateEntryRequest(id);
            if(_isValid)
            {
                _entryNotification.NotifyEntryGranted(id);
            }
        }
        public void DoorOpened()
        {
            _door.Close();
        }
        public void DoorClosed()
        {

        }
    }
}
