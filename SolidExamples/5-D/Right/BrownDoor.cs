using System;

namespace SolidExamples._5_D.Right
{
    public class BrownDoor : IDoor
    {
        public string GetColor()
        {
            return "I am a brown door";
        }

        public void OnClose()
        {
            Console.WriteLine("Opening brown door");
        }

        public void OnOpen()
        {
            Console.WriteLine("Closing brown door");
        }
    }
}
