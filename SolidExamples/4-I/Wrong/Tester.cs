using System;

namespace SolidExamples._4_I.Wrong
{
    public class Tester : IWorkable
    {
        public bool CanCode()
        {
            return false;
        }

        public void Code()
        {
            throw new NotImplementedException("Tester can not code");
        }

        public void Test()
        {
            Console.WriteLine("testing in the server");
        }
    }
}
