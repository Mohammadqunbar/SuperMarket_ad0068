using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_ad0068
{
    public partial class frmDairy : Form
    {
        string disable;
        public frmDairy()
        {
            InitializeComponent();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.chbmilk.Checked)
            {
                disable += chbmilk.Text;
                disable += "\n";
            }
            if (this.chbyogurt.Checked)
            {
                disable += chbyogurt.Text;
                disable += "\n";
            }
            if (this.chbcheese.Checked)
            {
                disable += chbcheese.Text;
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
            chbmilk.Checked = false;
            chbyogurt.Checked = false;
            chbcheese.Checked = false;
        }
    }
}
