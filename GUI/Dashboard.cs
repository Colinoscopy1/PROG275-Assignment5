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
    public partial class Dashboard : Form
    {
        DBContext db = new DBContext();
        User loggedInUser;
        LoginForm loginForm;
        public Dashboard(User loggedInUser, LoginForm loginForm)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            lblLoggedInUser.Text = loggedInUser.Username;
            this.loginForm = loginForm;
        }

        private void btnOpenCreateUserForm_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            Ticket newTicket = new Ticket();
            newTicket.DateCreated = DateTime.Now;
            newTicket.LastEdited = DateTime.Now;
            newTicket.Description = txtNewTicketDescription.Text;
            newTicket.Note = "";
            newTicket.Type = cmbNewTicketType.Text;
            newTicket.Status = cmbNewTicketStatus.Text;
            newTicket.Priority = cmbNewTicketPriority.Text;
            newTicket.CreatedBy = loggedInUser.Id;
            newTicket.AssignedTo = db.Users.Where(x => x.Username == cmbNewTicketAssignedTo.Text).FirstOrDefault().Id;
            try
            {
                db.Add(newTicket);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error creating the ticket. Did you fill in all the fields?");
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
    }
}
