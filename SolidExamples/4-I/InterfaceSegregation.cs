using SolidExamples._4_I.Right;
using SolidExamples._4_I.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._4_I
{
    public class InterfaceSegregation
    {
        public void Execute()
        {
            //Wrong way
            Programmer programmer = new Programmer();
            Tester tester = new Tester();
            IWorkable[] workables = new IWorkable[] { programmer, tester };
            foreach (var workable in workables)
            {
                if (workable.CanCode())
                {
                    workable.Code();
                }
            }

            //Correct way
            ProgrammerOk programmerOk = new ProgrammerOk();
            TesterOk testerOk = new TesterOk();
            //ICodeable[] codeables = new ICodeable[] { programmerOk, testerOk };
            ICodeable[] codeables = new ICodeable[] { programmerOk };
            foreach (var codeable in codeables)
            {
                codeable.Code();
            }
        }
    }
}
