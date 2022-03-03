using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public interface IDoor
    {
        public bool _isOpen { get; set; }
        public IDoorControl _doorControl { get; set; }
        public void Open();

        public void Close();
    }
}
