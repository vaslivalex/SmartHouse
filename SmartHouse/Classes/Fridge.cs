using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Fridge : ISwitchable, IInfoable, ITemperaturable
    {
        public void On()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public int Temperature
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

        public void TemperatureUp()
        {
            throw new NotImplementedException();
        }

        public void TemperatureDown()
        {
            throw new NotImplementedException();
        }
    }
}
