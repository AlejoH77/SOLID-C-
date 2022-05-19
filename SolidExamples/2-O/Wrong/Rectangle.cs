using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._2_O.Wrong
{
    public class Rectangle : IForm
    {
        int IForm.GetType()
        {
            return 1;
        }
    }
}
