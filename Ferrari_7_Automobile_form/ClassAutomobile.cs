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
        protected int _rpms;
        protected bool _onOff;
        protected int _numeroMarce;

        public ClassAutomobile()
        {
            _speed = 0;
            _gear = 0;
            _rpms = 0;
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
        public int rpms
        {
            get { return _rpms; }
            set { _rpms = value; }
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
            if (onOff && gear > 0 && rpms < 6000)
            {
                rpms += 2000;
                speed = ((rpms * gear) / 100) / 2;
                return 1;
            }
            return 0;
        }
        public int Frena()
        {
            if (onOff && speed > 0)
            {
                rpms -= 2000;
                speed = ( (rpms * gear) / 100 ) / 2;
                return 1;
            }
            return 0;
        }
        public int AumentaMarcia()
        {
            if (onOff)
            {
                if (gear == 0)
                {
                    gear++;
                    return 1;
                }
                else if (gear < 6 && rpms == 6000)
                {
                    gear++;
                    rpms = 2000;
                    return 1;
                }
            }
            return 0;
        }
        public int DiminuisciMarcia()
        {
            if (onOff)
            {
                if (gear > 0 && rpms == 2000)
                {
                    gear--;
                    rpms = 6000;
                    return 1;
                }
            }
            return 0;
        }
    }
}
