using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHouse.Enums;


namespace SmartHouse
{
    public class TV : Device, IVolumable, IBrightable, IChanelable
    {
        private BrightnessLevel brightness;
        private VolumeLevel volume;
        private byte chanel;
        public TV (bool state, BrightnessLevel brightness, byte chanel)
            :base()
        {
            this.State = state;
            this.brightness = brightness;
            this.Chanel = chanel;
        }
        public void SetLowBrightness()
        {
            brightness = BrightnessLevel.Low;
        }
        public void SetMediumBrightness()
        {
            brightness = BrightnessLevel.Medium;
        }
        public void SetHighBrightness()
        {
            brightness = BrightnessLevel.High;
        }
        public override string ToString()
        {
            string state;
            if (this.State)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }
            string brightness;
            if (this.brightness == BrightnessLevel.Low)
            {
                brightness = "слабая";
            }
            else if (this.brightness == BrightnessLevel.Medium)
            {
                brightness = "средняя";
            }
            else
            {
                brightness = "высокая";
            }
            byte chanel;
            if ()
            return "Состояние: " + state + ", яркость: " + brightness + ", текущий канал: " + ;
        }

        public byte Chanel
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
            Chanel++;
        }

        public void ChanelDown()
        {
            Chanel--;
        }

        public void VolumeUp()
        {
            volume++; 
        }

        public void VolumeDown()
        {
            volume--;
        }
    }
}
