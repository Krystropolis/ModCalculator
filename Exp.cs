using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Exp : ModWI
    {
        public Exp()
        {
            doCalc();
        }
        public override void doCalc()
        {
            getInputFromUser();
            double input = getInput();
            double value = getValue();
            setValue(Math.Pow(value, input));
        }
    }
}
