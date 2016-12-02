using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Cleaner : Device, IPowerable, ISwitchable
    {
        public void PowerUp()
        {
            throw new NotImplementedException();
        }

        public void PowerDown()
        {
            throw new NotImplementedException();
        }
    }
}
