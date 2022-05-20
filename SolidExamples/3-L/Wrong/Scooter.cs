using System;

namespace SolidExamples._3_L.Wrong
{
    public class Scooter : Vehicle
    {
        public new void GoForward(int velocity)
        {
            if (velocity > 100)
            {
                throw new Exception("Out of Bounds");
            }

            Position += velocity;
        }
    }
}
