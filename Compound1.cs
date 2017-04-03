using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Compound1 : CompoundMod
    {
        public Compound1()
        {
            doCalc();
        }
        public override void doCalc()
        {
            setModule(new Initialize());
            setModule(new Prod());
            setModule(new Exp());
            setModule(new Log()); 
        }
    }
}
