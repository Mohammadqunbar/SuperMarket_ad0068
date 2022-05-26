using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_ad0068
{
    public partial class frmSuperMarket : Form
    {
        private List<LoginUser> UsersList = new List<LoginUser>();
        public frmSuperMarket()
        {
            InitializeComponent();
            LoginUser user1 = new LoginUser("mohammed", "123");
            LoginUser user2 = new LoginUser("ghassan", "1234");
            LoginUser user3 = new LoginUser("alqunbar", "12345");
            UsersList.Add(user1);
            UsersList.Add(user2);
            UsersList.Add(user3);

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

        private void frmSuperMarket_Load(object sender, EventArgs e)
        {
            
        }
    }
}
