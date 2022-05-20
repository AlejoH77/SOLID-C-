using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._1_S.Wrong
{
    public class User
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        private UserDB userDB;

        public User()
        {
            userDB = new UserDB();
        }

        public int GetAge()
        {
            return DateTime.UtcNow.Year - Birthday.Year;
        }

        public bool ValidateUser()
        {
            if(!string.IsNullOrEmpty(Name) && GetAge() > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  bool SaveUser()
        {
            userDB.GetConnection();
            return userDB.SaveRecord(this);
        }

        public bool DeleteUser(User user)
        {
            userDB.GetConnection();
            return userDB.SaveRecord(this);
        }

    }
}
