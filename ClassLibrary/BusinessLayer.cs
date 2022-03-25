using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BusinessLayer
    {
        public static User LoggedInUser = null;

        public static DataTable GetAllTickets()
        {
            DataTable ret = new DataTable();

            using (DBContext db = new DBContext())
            {
                foreach (Ticket ticket in db.Tickets)
                {
                    ret.Rows.Add(db.Tickets);
                }
            }

            return ret;
        }

        public static DataTable GetMyTickets()
        {
            DataTable ret = new DataTable();

            using (DBContext db = new DBContext())
            {
                foreach (Ticket ticket in db.Tickets)
                {
                    ret.Rows.Add(db.Tickets.Where(x => x.CreatedBy == LoggedInUser.Id));
                }
            }

            return ret;
        }

        public static DataTable GetStatusTickets(string status)
        {
            DataTable ret = new DataTable();

            using (DBContext db = new DBContext())
            {
                foreach (Ticket ticket in db.Tickets)
                {
                    ret.Rows.Add(db.Tickets.Where(x => x.Status == status));
                }
            }

            return ret;
        }

        public static List<User> GetAllUsers()
        {
            List<User> ret = new List<User>();

            using (DBContext db = new DBContext())
            {
                foreach (User user in db.Users)
                {
                    ret.Add(user);
                }
            }

            return ret;
        }

        public static bool Login(string username, string password)
        {
            bool ret = false;

            using (DBContext db = new DBContext())
            {
                int count = db.Users.Where(x => x.Username == username && x.Password == password).Count();
                if (count == 1)
                {
                    ret = true;
                    LoggedInUser = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

                }
            }
            return ret;
        }

        //db.Users.Where(x => x.GetType().ToString() == discrim).FirstOrDefault().GetType().ToString();
        public static string GetUserDiscriminator(int userID)
        {
            string ret = "";

            using (DBContext db = new DBContext())
            {
                ret = db.Users.Where(x => x.Id == userID).FirstOrDefault().GetType().ToString().Split(".")[1];
            }
            //If we want to get rid of the class library. we can split on the . and return last or default
            //instead of firstordefault
            return ret;
        }

        public static bool AddNewUser(User u)
        {
            bool ret = false;

            using (DBContext db = new DBContext())
            {
                db.Add(u);
                db.SaveChanges();
                ret = true;
            }
            return ret;
        }

        public static bool RemoveUser(User u)
        {
            bool ret = false;

            using (DBContext db = new DBContext())
            {
                db.Remove(u);
                db.SaveChanges();
                ret = true;
            }
            return ret;
        }

        public static bool AddNewTicket(Ticket t)
        {
            bool ret = false;

            using (DBContext db = new DBContext())
            {
                db.Add(t);
                db.SaveChanges();
                ret = true;
            }
            return ret;
        }

        public static bool RemoveTicket(Ticket t)
        {
            bool ret = false;

            using (DBContext db = new DBContext())
            {
                db.Remove(t);
                db.SaveChanges();
                ret = true;
            }

            return ret;
        }

        public static List<User> GetAllUsersToMessage()
        {
            List<User> ret;

            using (DBContext db = new DBContext())
            {
                ret = db.Users.Where(x => x.Username != LoggedInUser.Username).ToList();
            }

            return ret;
        }

        public static bool SendMessage(User recipient, string message)
        {
            bool ret = false;

            using (DBContext db = new DBContext())
            {
                Message msg = new Message();
                msg.Content = message;
                msg.Sender = LoggedInUser;
                msg.Recipient = recipient;
                msg.MessageDate = DateTime.Now;
                db.Add(msg);
                db.SaveChanges();
                ret = true;
            }
            return ret;
        }



    }
}
