using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public interface IUserValidation
    {
        public bool ValidateEntryRequest(int id);
    }
}
