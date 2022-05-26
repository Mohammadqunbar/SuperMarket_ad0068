using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SuperMarket_ad0068
{
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source =C:\\Users\\SCHOOL\\Desktop\\mohammed alqunbor\\SuperMarket_ad0068.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into SuperMarket values(@ID, @Name, @price)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(txtNumber.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved is successfully");
            GetSuperMarket();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From SuperMarket Where ID=@ID";
            OleDbConnection super = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source =C:\\Users\\SCHOOL\\Desktop\\mohammed alqunbor\\SuperMarket_ad0068.accdb");

            OleDbCommand cmd = new OleDbCommand(delete, super);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            super.Open();

            cmd.ExecuteNonQuery();
            super.Close();
            MessageBox.Show("Delete is successfully");
            GetSuperMarket();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmData_Load(object sender, EventArgs e)
        {
            GetSuperMarket();
        }
        void GetSuperMarket()
        {
            OleDbConnection super = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =C:\\Users\\SCHOOL\\Desktop\\mohammed alqunbor\\SuperMarket_ad0068.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from SuperMarket", super);
            super.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            super.Close();
        }
    }
}
