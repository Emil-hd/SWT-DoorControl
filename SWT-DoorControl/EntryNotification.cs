using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    class EntryNotification
    {
        public void NotifyEntryGranted(int id)
        {
            Console.WriteLine("Døren er åbnet med Id" + id);
        }
        public void NotifyEntryDenied(int id)
        {
            Console.WriteLine("ID " + id + " er ikke gyldigt adgang ikke givet");
        }
    }
}
