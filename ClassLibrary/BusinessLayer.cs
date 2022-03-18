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
        //Some Small change
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

    }
}
