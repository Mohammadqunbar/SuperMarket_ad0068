using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_ad0068
{
    public partial class frmCleaning : Form
    {
        string disable;
        public frmCleaning()
        {
            InitializeComponent();
        }



        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.chbshampoo.Checked)
            {
                disable += chbshampoo.Text;
                disable += "\n";
            }
            if (this.chbsoap.Checked)
            {
                disable += chbsoap.Text;
                disable += "\n";
            }
            if (this.chbperfumed.Checked)
            {
                disable += chbperfumed.Text;
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
            ClearAllFileds();
        }
        private void ClearAllFileds()
        {
            cmbQuantity.SelectedIndex = 0;
            chbshampoo.Checked = false;
            chbsoap.Checked = false;
            chbperfumed.Checked = false;

        }
    }
}
