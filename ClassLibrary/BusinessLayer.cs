using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public  class BusinessLayer
    {
        public static User LoggedInUser = null;
        
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
                ret = db.Users.Where(x => x.Id == userID).FirstOrDefault().GetType().ToString();
            }

            return ret;
        }

    }
}
