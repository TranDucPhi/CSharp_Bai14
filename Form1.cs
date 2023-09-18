using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtQuidoi.Text);
            txtKq.Text = Math.Round(sotien*17861,2).ToString();
        }

        private void txtQuidoi_Leave(object sender, EventArgs e)
        {
         
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1])) 
            {
                 this.errorProvider1.SetError(ctr, "This is not avalid number");
                btncndtoeur.Enabled = false;
                btneurtovnd.Enabled = false;
                btnusdtovnd.Enabled = false;
                btnvndtousd.Enabled = false;
            }
            else 
            { 
                this.errorProvider1.Clear();
                btncndtoeur.Enabled = true;
                btneurtovnd.Enabled = true;
                btnusdtovnd.Enabled = true;
                btnvndtousd.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btncndtoeur.Enabled = false;
            btneurtovnd.Enabled = false;
            btnusdtovnd.Enabled = false;
            btnvndtousd.Enabled = false;
        }
    }
}
