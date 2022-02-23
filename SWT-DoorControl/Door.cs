using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    class Door
    {
        public bool _isOpen { get; set; }
        public Door()
        {
            _isOpen = false;
        }
        public void Open()
        {
            _isOpen = true;
        }
        public void Close()
        {
            _isOpen = false;
        }
    }
}
