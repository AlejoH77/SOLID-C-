using System;

namespace SolidExamples._4_I.Right
{
    //Interface composition
    public class ProgrammerOk : ICodeable, ITesteable
    {
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
