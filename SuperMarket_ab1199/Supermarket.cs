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
    public partial class Supermarket : Form
    {
        private List<LoginUser> UsersList = new List<LoginUser>();
        public Supermarket()
        {
            InitializeComponent();
            LoginUser user1 = new LoginUser("hamza", "123");
            UsersList.Add(user1);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            foreach (LoginUser user in UsersList)
            {
                if (username == user.UserName && password == user.Password)
                {
                    frmLogin frm = new frmLogin(txtUserName.Text);
                    frm.Show();
                    return;
                }
            }
        }
    }
}
