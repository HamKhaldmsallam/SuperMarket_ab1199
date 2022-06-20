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
    public partial class addform3 : Form
    {
        public addform3()
        {
            InitializeComponent();
        }
        string database = "Provider=Microsoft.ACE.OLEDB.12.0; " +
              "Data Source = SuperMarket_ab1199.accdb";

        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(database);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Dairy_Products", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(database);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Dairy_Products values(@ID, @Dairy_Products)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Dairy_Products", txtName.Text);



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
