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
            try
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
                db.Add(newTicket);
                db.SaveChanges();
                MessageBox.Show("Ticket was successfully created!");
            }
            catch
            {
                MessageBox.Show("Error creating the ticket. Did you fill in all the fields?");
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();//Something Wrong Here
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //changing form based on user access, hide create user button if they're not admin and hide all tickets if they're just a user
            string currentUserType = BusinessLayer.GetUserDiscriminator(loggedInUser.Id);

            if (currentUserType != "Admin")
                btnOpenCreateUserForm.Enabled = false;

            if (currentUserType == "User")
                tabTickets.Hide();

            //populate the combobox with users
            foreach (User user in BusinessLayer.GetAllUsers())
            {
                cmbNewTicketAssignedTo.Items.Add(user.Username);
                cmbMyTicketAssignedTo.Items.Add(user.Username);
                cmbTicketAssignedTo.Items.Add(user.Username);
            }

            //populate the data grid views
            dgvAllTickets.DataSource = BusinessLayer.GetAllTickets();
            dgvMyTickets.DataSource = BusinessLayer.GetMyTickets();

        }

        private void btnUpdateMyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedTicketId = Convert.ToInt32(dgvMyTickets.Rows[dgvMyTickets.CurrentRow.Index].Cells[0].Value);
                var ticketToEdit = db.Tickets.SingleOrDefault(x => x.Id == selectedTicketId);
                ticketToEdit.Description = txtMyTicketDescription.Text;
                ticketToEdit.Note = txtMyTicketNotes.Text;
                ticketToEdit.Type = cmbMyTicketType.Text;
                ticketToEdit.Status = cmbMyTicketStatus.Text;
                ticketToEdit.AssignedTo = db.Users.SingleOrDefault(x => x.Username == cmbMyTicketAssignedTo.Text).Id;
                db.SaveChanges();
                MessageBox.Show("Ticket successfully updated.");
            }
            catch
            {
                MessageBox.Show("Error updating ticket.");
            }
}

        private void btnUpdateTIcket_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedTicketId = Convert.ToInt32(dgvAllTickets.Rows[dgvAllTickets.CurrentRow.Index].Cells[0].Value);
                var ticketToEdit = db.Tickets.SingleOrDefault(x => x.Id == selectedTicketId);
                ticketToEdit.Description = txtTicketDescription.Text;
                ticketToEdit.Note = txtTicketNotes.Text;
                ticketToEdit.Type = cmbTicketType.Text;
                ticketToEdit.Status = cmbTicketStatus.Text;
                ticketToEdit.AssignedTo = db.Users.SingleOrDefault(x => x.Username == cmbTicketAssignedTo.Text).Id;
                db.SaveChanges();
                MessageBox.Show("Ticket successfully updated.");
            } catch
            {
                MessageBox.Show("Error updating ticket.");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvAllTickets.DataSource = null;
            dgvAllTickets.DataSource = BusinessLayer.GetAllTickets();
        }

        private void btnShowPending_Click(object sender, EventArgs e)
        {
            dgvAllTickets.DataSource = null;
            dgvAllTickets.DataSource = BusinessLayer.GetStatusTickets("Pending");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvAllTickets.DataSource = null;
            dgvAllTickets.DataSource = BusinessLayer.GetStatusTickets("Completed");
        }
    }
}
