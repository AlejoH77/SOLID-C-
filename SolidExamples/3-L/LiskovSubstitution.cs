using SolidExamples._3_L.Right;
using SolidExamples._3_L.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._3_L
{
    public class LiskovSubstitution
    {
        /* Considerations:
         * + The client must use methods of the parent class only
         * + If the child class alters the behavior of the methods of the parent class, it must behave accordingly.
        */

        public void Execute()
        {
            //Wrong way
            Vehicle vehicle = new Vehicle();
            Scooter scooter = new Scooter();
            vehicle.GoForward(150);
            scooter.GoForward(150);

            //Correct way
            // Is the relationship between the classes inheritance?
            CarOk carOk = new CarOk();
            ScooterOk scooterOk = new ScooterOk();
            carOk.GoForward(150);
            scooterOk.GoForward(150);

        }
    }
}
