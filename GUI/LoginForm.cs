using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace GUI
{
    public partial class LoginForm : Form
    {
        bool success = false;
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login code
            bool success = BusinessLayer.Login(txtUsername.Text, txtPassword.Text);
            if (success)
            {
                Dashboard dashboard = new Dashboard(BusinessLayer.LoggedInUser);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Failed to Login");
            }
            //this.Close();

        }
    }
}
