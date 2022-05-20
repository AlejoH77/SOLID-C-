using System;

namespace SolidExamples._3_L.Right
{
    public class CarOk : IVehicleOk
    {
        public override void GoForward(int velocity)
        {
            if (velocity < 0 || velocity > 200)
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
