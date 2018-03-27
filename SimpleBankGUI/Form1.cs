using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBankGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxClear();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + textBoxName.Text + "\n\nAge: " + textBoxAge.Text + "\n\nAddress: " 
                + textBoxAddress.Text + "\n\nTelephone Number: " + textBoxTelephoneNumber.Text);
            textBoxClear();
        }

        public void textBoxClear()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxAddress.Clear();
            textBoxTelephoneNumber.Clear();
        }
    }
}
