using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    interface IDoor
    {
        public bool _isOpen { get; set; }
        public DoorControl doorControl { get; set; }
        public void Open();

        public void Close();
    }
}
