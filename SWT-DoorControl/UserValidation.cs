using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public class UserValidation: IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            if(id>=0 && id<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
