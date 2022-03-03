using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("ALARM ALARM!!");
        }
    }
}
