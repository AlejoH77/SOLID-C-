using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._5_D.Right
{
    public class BigWindow : IWindow
    {
        public string GetSize()
        {
            return "I am a big window";
        }

        public void OnClose()
        {
            Console.WriteLine("Opening big window");
        }

        public void OnOpen()
        {
            Console.WriteLine("Closing big window");
        }
    }
}
