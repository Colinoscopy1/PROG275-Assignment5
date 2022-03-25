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

    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (cmbUserType.Text == "Technician")
            {
                Technician tech = new Technician();
                tech.Username = txtUsername.Text;
                tech.FirstName = txtFirstName.Text;
                tech.DateRegistered = DateTime.Now;
                tech.LastName = txtLastName.Text;
                tech.Password = txtPassword.Text;
                tech.CanEdit = true;
                BusinessLayer.AddNewUser(tech);
            }
            else if(cmbUserType.Text == "User")
            {
                User user = new User();
                user.Username = txtUsername.Text;
                user.FirstName = txtFirstName.Text;
                user.DateRegistered = DateTime.Now;
                user.LastName = txtLastName.Text;
                user.Password = txtPassword.Text;
            }

            //code to create user
            this.Close();
        }
    }
}
