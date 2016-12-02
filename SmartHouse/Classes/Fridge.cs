using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Fridge : Device, ISwitchable, ITemperaturable
    {
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
