using SolidExamples._5_D.Right;
using SolidExamples._5_D.Wrong;

namespace SolidExamples._5_D
{
    public class DependencyInversion
    {
        public void Execute()
        {
            //Wrong way
            House house = new House();

            //Correct way
            BrownDoor brownDoor = new BrownDoor();
            BigWindow bigWindow = new BigWindow();
            HouseOk houseOk = new HouseOk(brownDoor, bigWindow);
        }
    }
}
