using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_ab1199
{
    public partial class frmLogin : Form
    {
        private string Username;
        public frmLogin(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            frmCooking frm1 = new frmCooking();
            frm1.TopLevel = false;
            this.panel3.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            frmCleaning frm2 = new frmCleaning();
            frm2.TopLevel = false;
            this.panel3.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnDairy_Click(object sender, EventArgs e)
        {
            frmDairy frm3 = new frmDairy();
            frm3.TopLevel = false;
            this.panel3.Controls.Add(frm3);
            frm3.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lblWel.Text = "Welcome " + Username;
        }
    }
}
