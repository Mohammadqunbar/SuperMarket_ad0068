﻿using System;
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
    public partial class addform1 : Form
    {
        public addform1()
        {
            InitializeComponent();
        }
        string database = "Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source =C:\\Users\\SCHOOL\\Desktop\\mohammed alqunbor\\SuperMarket_ad0068\\SuperMarket_ad0068\\database\\SuperMarket_ad0068.accdb";

        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(database);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Cooking_and_Baking", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(database);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Cooking_and_Baking values(@ID, @Cooking_and_Baking)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Cooking_and_Baking", txtName.Text);



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }
    }
}
