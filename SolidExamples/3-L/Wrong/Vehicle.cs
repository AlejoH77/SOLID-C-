using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._3_L.Wrong
{
    public class Vehicle
    {
        public int Position { get; set; }

        public void GoForward(int velocity)
        {
            if(velocity < 0 || velocity > 200)
            {
                throw new Exception("Out of Bounds");
            }

            Position += velocity;
        }

    }
}
