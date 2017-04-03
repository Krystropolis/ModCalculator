using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    abstract class CompoundMod: Module
    {
        private ModuleIF m;
        public abstract override void doCalc();
        public ModuleIF getModule()
        {
            return m;
        }
        public void setModule(ModuleIF mod)
        {
            this.m = mod;
        }
    }
}
