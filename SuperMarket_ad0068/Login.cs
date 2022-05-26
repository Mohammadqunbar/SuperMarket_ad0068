using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_ad0068
{
    public partial class frmLogin : Form
    {
        private string Username;
        public frmLogin(string username)
        {
            Username = username;
            InitializeComponent();

        }


        private void btnForm1_Click_1(object sender, EventArgs e)
        {
            frmCooking frm1 = new frmCooking();
            frm1.TopLevel = false;
            this.panel3.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            frmCleaning frm2 = new frmCleaning();
            frm2.TopLevel = false;
            this.panel3.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            frmDairy frm3 = new frmDairy();
            frm3.TopLevel = false;
            this.panel3.Controls.Add(frm3);
            frm3.Show();
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            lblWel.Text = "Welcome " + Username;
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            frmData frmdata = new frmData();
            frmdata.TopLevel = false;
            this.panel3.Controls.Add(frmdata);
            frmdata.Show();
        }
    }
}
