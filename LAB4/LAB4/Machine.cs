using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public abstract class Machine
    {
        private string name;
        public abstract void TurnOff();
        public abstract void TurnOn();
        public abstract void Reboot();
    }


}
