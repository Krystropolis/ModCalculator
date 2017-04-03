using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L004
{
    public abstract class ModWI: Module
    {
        private double input;
        public abstract override void doCalc();
        public double getInput()
        {
            return input;
        }
        public void setInput(double i)
        {
            this.input = i;
        }
        public void getInputFromUser()
        {
            var form = new InputDialog(this);
            form.ShowDialog();
        }
    }
}
