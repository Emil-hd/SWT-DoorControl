using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public interface IDoorControl
    {
        public IDoor _door { get; set; }
        public IEntryNotification _entryNotification { get; set; }
        public IUserValidation _userValidation { get; set; }
        public bool _isValid { get; set; }
        public bool _isDoorOpen { get; set; }
        public void RequestEntry(int id);
        public void DoorOpened();
        public void DoorClosed();
    }
}
