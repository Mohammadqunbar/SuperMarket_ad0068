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
    public partial class frmCooking : Form
    {

        public frmCooking()
        {
            InitializeComponent();
            fill_ListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Order : \n" + lbxSelection4.Text + " \n Quantity : \n" + cmbQuantity.SelectedItem);
            
        }

        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
                string selection = "Select Cooking_and_Baking from Cooking_and_Baking";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lbxSelection4.Items.Add(myReader["Cooking_and_Baking"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  " + ex);
            }
        }
        private void btnclear_Click_1(object sender, EventArgs e)
        {
            cmbQuantity.SelectedIndex = 0;
            lbxSelection4.ClearSelected();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addform1 frm1 = new addform1();
            frm1.Show();
        }

        private void frmCooking_Load(object sender, EventArgs e)
        {
        }
    }
}
