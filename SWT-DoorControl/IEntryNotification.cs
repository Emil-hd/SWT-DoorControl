using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public interface IEntryNotification
    {
        public void NotifyEntryGranted(int id);
        public void NotifyEntryDenied(int id);
    }
}
