using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L004
{
    public partial class Client : Form
    {
        private FactoryIF f = new Factory();

        public Client()
        {
            InitializeComponent();
            string[] modLog = File.ReadAllLines("C:\\Users\\iimax\\Documents\\Visual Studio 2015\\Projects\\s421_lab4\\L004\\L004\\modules.txt");   // contains the calculation modules in text form
            List<string> modList = new List<string>(modLog); // list of all calculation modules
            modList.Sort(); // sort the modules alphabetically
            int startingIndex = 0;  // will be used to store the "initialize" module, or whichever module should be executed first
            int i = 0; // index of mod
            foreach (string mod in modList)
            {   
                try
                {
                    modComboBox.Items.Add(mod);
                    if (mod.ToLower() == "initialize") { startingIndex = i; } // will help with program intuitiveness
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                i++; // increment mod index
            }
            modComboBox.SelectedIndex = startingIndex;
        }

        private void modComboBox_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            // select the calculation module
            string m = this.modComboBox.GetItemText(this.modComboBox.SelectedItem).ToLower();
            if (m == "compound1")
            {
                f.setMod(new Compound1());
            }
            else if (m == "compound2")
            {
                f.setMod(new Compound2());
            }
            else if (m == "subtract")
            {
                f.setMod(new Sub());
            }
            else if (m == "sum")
            {
                f.setMod(new Sum());
            }
            else if (m == "product")
            {
                f.setMod(new Prod());
            }
            else if (m == "power")
            {
                f.setMod(new Exp());
            }
            else if (m == "log")
            {
                f.setMod(new Log());
            }
            else if (m == "initialize")
            {
                f.setMod(new Initialize());
            }
            // display the result of the calculation
            finalValue.Text = Convert.ToString(f.getMod().getValue());
            finalValue.Refresh();
        }
    }
}
