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

namespace SuperMarket_ab1199
{
    public partial class addform2 : Form
    {
        public addform2()
        {
            InitializeComponent();
        }
        string database = "Provider=Microsoft.ACE.OLEDB.12.0; " +
        "Data Source = SuperMarket_ab1199.accdb";

        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(database);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Cleaning_Materials", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(database);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Cleaning_Materials values(@ID, @Cleaning_Materials)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Cleaning_Materials", txtName.Text);



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }
    }
}
