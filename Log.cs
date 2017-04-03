using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Log : ModWOI
    {
        public Log()
        {
            doCalc();  
        }
        public override void doCalc()
        {
            setValue(Math.Log10(getValue()));
        }
    }
}
