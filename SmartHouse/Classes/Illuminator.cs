using SmartHouse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Illuminator : Device, IBrightable
    {
        private BrightnessLevel brightness;
        public Illuminator(bool state, BrightnessLevel brightness)
            :base()
        {
            this.State = state;
            this.brightness = brightness;
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
            return "Состояние: " + state + ", яркость: " + brightness;
        }
    }
}
