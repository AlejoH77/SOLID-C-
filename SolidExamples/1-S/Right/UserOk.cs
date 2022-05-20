using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._1_S.Right
{
    public class UserOk
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            return DateTime.UtcNow.Year - Birthday.Year;
        }
    }
}
