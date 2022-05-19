using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._5_D.Wrong
{
    public class House
    {
        private Door _door;
        private Window _window;

        public House()
        {
            //House depende de dos Door y Window, es decir, de clases concretas y no de abstracciones
            _door = new Door();
            _window = new Window();
        }
    }
}
