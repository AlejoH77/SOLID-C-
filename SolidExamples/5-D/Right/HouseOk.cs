using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._5_D.Right
{
    public class HouseOk
    {

        private IDoor _door;
        private IWindow _window;

        public HouseOk(IDoor door, IWindow window)
        {
            _door = door;
            _window = window;
        }
    }
}
