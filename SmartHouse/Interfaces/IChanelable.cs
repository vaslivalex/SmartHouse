using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IChanelable
    {
        int Chanel
        {
            get;
            set;
        }
    
        void ChanelUp();

        void ChanelDown();
    }
}
