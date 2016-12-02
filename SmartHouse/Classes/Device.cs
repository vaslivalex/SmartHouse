using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    abstract public class Device
    {
        private bool state;
        public bool State
        {
            get { return State; }
            set { state = value; }
        }
        public void On()
        {
            state = true;
        }
        public void Off()
        {
            state = false;
        }
        public override string ToString();
    }
}
