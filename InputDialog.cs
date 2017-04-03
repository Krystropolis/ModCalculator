using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L004
{
    public partial class InputDialog : Form
    {
        private ModWI m;
        private double input;

        public InputDialog(ModWI mod)
        {
            InitializeComponent();
            m = mod;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // submit the value for calculation, report invalid input if value is not acceptable
            try
            {
                input = Convert.ToDouble(inputTxt.Text);
                m.setInput(input);
                this.Close();
            }
            catch (Exception except)
            {
                inputTxt.Text = ("Invalid Input");
                inputTxt.Refresh();
                Console.WriteLine(except.ToString());
            }
        }

        private void inputTxt_Enter(object sender, EventArgs e)
        {
            inputTxt.Text = "";
            ActiveForm.AcceptButton = submitBtn;
        }

        private void inputTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitBtn.PerformClick();
            }
        }
    }
}
