using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._1_S.Right
{
    public class UserValidationService
    {
        public bool ValidateUser(UserOk user)
        {
            if (!string.IsNullOrEmpty(user.Name) && user.GetAge() > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
