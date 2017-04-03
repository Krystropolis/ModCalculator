using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Initialize : ModWI
    {
        public Initialize()
        {
            doCalc();
        }
        public override void doCalc()
        {
            getInputFromUser();
            double input = getInput();
            setValue(input);
        }
    }
}
