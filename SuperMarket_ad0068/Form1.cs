using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_ad0068
{
    public partial class frmCooking : Form
    {
        private string disable;
        public frmCooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.chbrice.Checked)
            {
                disable += chbrice.Text;
                disable += "\n";
            }
            if (this.chbnoodles.Checked)
            {
                disable += chbnoodles.Text;
                disable += "\n";
            }
            if (this.chbSpices.Checked)
            {
                disable += chbSpices.Text;
                disable += "\n";
            }
            if (this.chbcannedfood.Checked)
            {
                disable += chbcannedfood.Text;
                disable += "\n";
            }
            MessageBox.Show("Order : \n" + disable + "Quantity : \n" + cmbQuantity.SelectedItem);
            
        }

        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbQuantity.SelectedIndex = 0;
            chbrice.Checked = false;
            chbnoodles.Checked = false;
            chbSpices.Checked = false;
            chbcannedfood.Checked = false;
        }
    }
}
