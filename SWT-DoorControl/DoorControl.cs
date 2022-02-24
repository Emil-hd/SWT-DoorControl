using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_DoorControl
{
    public class DoorControl:IDoorControl
    {
        public IAlarm _alarm;
        public IDoor _door { get; set; }
        public IEntryNotification _entryNotification { get; set; }
        public IUserValidation _userValidation { get; set; }
        public bool _isValid { get; set; }
        public bool _isDoorOpen { get; set; }
        public DoorControl(IDoor door, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _alarm = new Alarm();
            _door = door;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
            _isValid = false;
            _isDoorOpen = false;
        }
        public void RequestEntry(int id)
        {
            _isValid=_userValidation.ValidateEntryRequest(id);
            if(_isValid)
            {
                _entryNotification.NotifyEntryGranted(id);
            }
            else if(!_isValid)
            {
                _entryNotification.NotifyEntryDenied(id);
            }
        }
        public void DoorOpened()
        {

            _isDoorOpen = true;


            if (_isValid == false)
            {
                _alarm.RaiseAlarm(); 
            }
            _door.Close();

        }
        public void DoorClosed()
        {
            _isDoorOpen = false;
            _isValid = false;
        }
    }
}
