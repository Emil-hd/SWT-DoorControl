using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    interface IDoorControl
    {
        public IDoor _door { get; set; }
        public EntryNotification _entryNotification { get; set; }
        public UserValidation _userValidation { get; set; }
        public bool _isValid { get; set; }
        public bool _isDoorOpen { get; set; }
        public void RequestEntry(int id);
        public void DoorOpened();
        public void DoorClosed();
    }
}
