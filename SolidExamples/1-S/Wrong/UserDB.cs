using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._1_S.Wrong
{
    public class UserDB
    {
        public void GetConnection()
        {

        }

        public bool SaveRecord(User user)
        {
            Console.WriteLine("Usuario {0} guardado", user.Name);
            return true;
        }

        public bool DeleteRecord(User user)
        {
            Console.WriteLine("Usuario {0} eliminado", user.Name);
            return true;
        }
    }
}
