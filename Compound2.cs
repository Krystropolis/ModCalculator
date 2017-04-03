using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Compound2 : CompoundMod
    {
        public Compound2()
        {
            doCalc();
        }
        public override void doCalc()
        {
            setModule(new Sum());
            setModule(new Prod());
            setModule(new Log());
        }
    }
}
