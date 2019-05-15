using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsChap2may15th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayOutput_Click(object sender, EventArgs e)
        {
            String buffer;
            buffer = "Mailing Label:" + Environment.NewLine + Environment.NewLine;
            buffer = buffer + "      Name: " + txtName.Text + Environment.NewLine;
            buffer = buffer + "Address: " + txtAddress.Text + Environment.NewLine;
            buffer = buffer + "      City: " + txtCity.Text + "   State:  " + txtState.Text + "   Zip:" + txtZip.Text;
            txtDisplayOutput.Text = buffer;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
