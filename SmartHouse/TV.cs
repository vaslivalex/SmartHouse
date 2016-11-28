using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class TV : ISwitchable, IVolumable, IBrightable, IInfoable, IChanelable
    {
        private bool state;
        public void On()
        {
            state = true;
        }
        public void Off()
        {
            state = false;
        }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public int Chanel
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ChanelUp()
        {
            throw new NotImplementedException();
        }

        public void ChanelDown()
        {
            throw new NotImplementedException();
        }
    }
}
