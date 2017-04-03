using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    public abstract class Module : ModuleIF
    {
        private static double value;
        public double getValue()
        {
            return value;
        }
        public void setValue(double val)
        {
            value = val;
        }
        public abstract void doCalc();
    }
}
