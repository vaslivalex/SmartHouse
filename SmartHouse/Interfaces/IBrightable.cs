using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IBrightable
    {
        void SetLowBrightness();

        void SetMediumBrightness();

        void SetHighBrightness();
    }
}
