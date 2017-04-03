using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004
{
    class Factory: FactoryIF
    {
        private ModuleIF m;
        public ModuleIF getMod()
        {
            return m;
        }
        public void setMod(ModuleIF mod)
        {
            this.m = mod;
        }
    }
}
