using SolidExamples._1_S.Right;
using SolidExamples._1_S.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._1_S
{
    public class SingleResponsibility
    {
        public void Execute()
        {
            //Wrong way
            User user = new();
            user.ValidateUser();
            user.SaveUser();

            //Correct way
            UserOk userOk = new UserOk();
            UserValidationService userValidationService = new UserValidationService();
            UserDBOk userDB = new UserDBOk();
            userValidationService.ValidateUser(userOk);
            userDB.SaveUser(userOk);
        }
    }
}
