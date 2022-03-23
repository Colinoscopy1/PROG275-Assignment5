using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Linq;


namespace UnitTests_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Discriminator_Grab()
        {
            DBContext db = new DBContext();

            Assert.AreEqual("Admin", BusinessLayer.GetUserDiscriminator(1));
        }

        [TestMethod]
        public void Test_AddUser_And_RemoveUser()
        {
            User tmp = new User();
            tmp.Username = "AddTest";
            tmp.Password = "password";
            tmp.FirstName = "Test";
            tmp.LastName = "Add";
            tmp.DateRegistered = DateTime.Now;

            BusinessLayer.AddNewUser(tmp);

            using (DBContext db = new DBContext())
            {
                Assert.AreEqual(1, db.Users.Where(x => x.Username == "AddTest").Count());
                BusinessLayer.RemoveUser(tmp);
                Assert.AreEqual(0, db.Users.Where(x => x.Username == "AddTest").Count());
            }
        }

        [TestMethod]
        public void Test_AddTicket_And_RemoveTicket()
        {
            using (DBContext db = new DBContext())
            {
                Ticket t = new Ticket();
                t.AcceptedBy = 1;
                t.AssignedTo = 1;
                t.CreatedBy = 1;
                t.DateCreated = DateTime.Now;
                t.Description = "Test";
                t.Type = "Test";
                t.Status = "Pending";
                t.Priority = "Urgent";
                t.Note = "Testing";

                BusinessLayer.AddNewTicket(t);

                Assert.AreEqual(1, db.Tickets.Where(x => x.Description == "Test").Count());

                BusinessLayer.RemoveTicket(t);

                Assert.AreEqual(0, db.Tickets.Where(x => x.Description == "Test").Count());
            }
        }
    }
}
