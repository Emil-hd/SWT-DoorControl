using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public class Door: IDoor
    {
        public bool _isOpen { get; set; }
        public IDoorControl _doorControl { get; set; }
        public Door(IDoorControl doorControl)
        {
            _doorControl = doorControl;
            _isOpen = false;
        }
        public void Open()
        {
            _isOpen = true;
            _doorControl.DoorOpened();
        }
        public void Close()
        {
            _isOpen = false;
            _doorControl.DoorClosed();
        }

    }
}
