using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_7_Automobile_form
{
    class ClassAutomobile
    {
        protected int _speed;
        protected int _gear;
        protected bool _onOff;

        public ClassAutomobile()
        {
            _speed = 0;
            _gear = 0;
            _onOff = false;
        }
        public int speed
        { 
            get { return _speed; } 
            set { _speed = value; } 
        }
        public int gear
        {
            get { return _gear; }
            set { _gear = value; }
        }
        public bool onOff
        {
            get { return _onOff; }
            set { _onOff = value; }
        }
        public int AccendiAuto()
        {
            if (!onOff)
            {
                onOff = true;
                return 1;
            }
            return 0;
        }
        public int SpegniAuto()
        {
            if (onOff) 
            {
                onOff = false;
                return 1;
            }
            return 0;
        }
        public int Accelera()
        {
            if (onOff && gear > 0)
            {

            }
            return 0;
        }
    }
}
