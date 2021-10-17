using FinTracker.Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincTracker.Lib.Serivces
{
    public class LoginService
    {
        public User Validator(string username, string password)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                User user = new User();
                user = db.Users.Where(x => x.Username == username && x.Password == password && !x.IsDeleted).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public async Task<bool> AddUser( User data)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                User user = new User();
                var username = db.Users.Where(x => !x.IsDeleted).Select(x => x.Username).ToList();
                if(username.Contains(data.Username))
                {
                    return false;
                }
                else
                {
                    db.Users.Add(data);
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
