using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Sub : ModWI
    {
        public Sub()
        {
            doCalc();
        }
        public override void doCalc()
        {
            getInputFromUser();
            double input = getInput();
            double value = getValue();
            setValue(value - input);
        }
    }
}
