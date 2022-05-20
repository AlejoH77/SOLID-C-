using System;

namespace SolidExamples._3_L.Right
{
    public class ScooterOk : VehicleOk
    {
        public override void GoForward(int velocity)
        {
            if (velocity > 100)
            {
                throw new Exception("Out of Bounds");
            }

            Position += velocity;
        }
    }
}
