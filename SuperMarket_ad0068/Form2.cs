using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SuperMarket_ad0068
{
    public partial class frmCleaning : Form
    {
        public frmCleaning()
        {
            InitializeComponent();
            fill_ListBox();
        }



        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Order : \n" + lbxSelection4.Text + " \n Quantity : \n" + cmbQuantity.SelectedItem);
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
            lbxSelection4.ClearSelected();


        }
        string database = "Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source = SuperMarket_ad0068.accdb";
        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(database);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select Dairy_Products from Dairy_Products";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lbxSelection4.Items.Add(myReader["Dairy_Products"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  " + ex);
            }
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addform2 frm2 = new addform2();
            frm2.Show();
        }
    }
}
