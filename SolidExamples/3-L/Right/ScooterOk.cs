using System;

namespace SolidExamples._3_L.Right
{
    public class ScooterOk : IVehicleOk
    {
        public override void GoForward(int velocity)
        {
            if (velocity > 100)
            {
                throw new Exception("Out of Bounds");
            }
            else
            {
                Console.WriteLine("Advancing {0}km", velocity);
            }
        }
    }
}
