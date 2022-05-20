using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._1_S.Right
{
    public class UserDBOk
    {
        public bool SaveUser(UserOk user)
        {
            Console.WriteLine("Usuario {0} guardado", user.Name);
            return true;
        }

        public bool DeleteUser(UserOk user)
        {
            Console.WriteLine("Usuario {0} eliminado", user.Name);
            return true;
        }
    }
}
