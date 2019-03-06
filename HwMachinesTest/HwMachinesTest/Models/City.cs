using System;

namespace HwMachinesTest
{
    internal class City
    {
        public event EventHandler<StatusEventArgs> StatusControlEvent;
        private CityStatus _status;

        public string Name { get; internal set; }

        public CityStatus Status
        {
            get { return _status; }
            internal set
            {
                _status = value;
                StatusControlEvent(this, new StatusEventArgs() {NewStatus = _status});
            }
        }
    }
    public class StatusEventArgs : EventArgs
    {
        public CityStatus NewStatus { get; set; }
    }
}