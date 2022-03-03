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
        public DoorControl doorControl { get; set; }
        public Door()
        {
            _isOpen = false;
        }
        public void Open()
        {
            _isOpen = true;
            doorControl.DoorOpened();
        }
        public void Close()
        {
            _isOpen = false;
            doorControl.DoorClosed();
        }

    }
}
