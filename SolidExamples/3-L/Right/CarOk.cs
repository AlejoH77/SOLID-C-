using System;

namespace SolidExamples._3_L.Right
{
    public class CarOk : VehicleOk
    {
        public override void GoForward(int velocity)
        {
            if (velocity < 0 || velocity > 200)
            {
                throw new Exception("Out of Bounds");
            }

            Position += velocity;
        }
    }
}
