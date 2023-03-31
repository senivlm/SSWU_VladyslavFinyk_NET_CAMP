using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class Pump
    {
        private float _power;
        private bool _isOn;

        public Pump(float power)
        {
            _power = power;   
        }

        public void TurnOn() { }
        public void TurnOff() { }
        public void PumpWater() { }
        public void StopPumping() { }

        public override string ToString()
        {
            return  "Pump info {" +   
                    $"   Pover:\t{_power}" + "\n" +
                    $"   Is on:\t{_isOn}" + "\n"
                    + "}";
        }
    }
}
