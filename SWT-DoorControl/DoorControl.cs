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
            _isValid = false;
        }
        public void ValidateEntryRequest(int id)
        {
            _isValid=_userValidation.ValidateEntryRequest(id);
        }
        public void DoorOpened()
        {
            _door.Close();
        }
    }
}
