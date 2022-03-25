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
        public Dashboard()
        {
            InitializeComponent();
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
            newTicket.CreatedBy = db.Users.Where(x => x.Username == lblLoggedInUser.Text).FirstOrDefault().Id;
            newTicket.AssignedTo = db.Users.Where(x => x.Username == lblNewTicketAssignedTo.Text).FirstOrDefault().Id;
            db.Add(newTicket);
            db.SaveChanges();
        }
    }
}
