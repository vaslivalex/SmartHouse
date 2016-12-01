using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ITemperaturable
    {
        int Temperature
        {
            get;
            set;
        }
        void TemperatureUp();
        void TemperatureDown();
    }
}
