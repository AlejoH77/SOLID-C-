using System;

namespace SolidExamples._4_I.Wrong
{
    public class Programmer : IWorkable
    {
        public bool CanCode()
        {
            return true;
        }

        public void Code()
        {
            Console.WriteLine("coding....");
        }

        public void Test()
        {
            Console.WriteLine("testing in localhost");
        }
    }
}
