using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._3_L.Right
{
    public abstract class VehicleOk
    {
        public int Position { get; set; }

        public abstract void GoForward(int velocity);
    }
}
