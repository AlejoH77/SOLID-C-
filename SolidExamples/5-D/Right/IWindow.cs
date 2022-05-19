using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._5_D.Right
{
    public interface IWindow
    {
        string GetSize();
        void OnOpen();
        void OnClose();
    }
}
