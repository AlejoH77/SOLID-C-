using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples._2_O.Wrong
{
    public class GraphicEditor
    {
        public void DrawForm(IForm form)
        {
            switch(form.GetType())
            {
                case 1:
                    DrawCircle((Circle)form);
                    break;
                case 2:
                    DrawRectangle((Rectangle)form);
                    break;
            }
        }

        private void DrawCircle(Circle c)
        {
            Console.WriteLine("painting a circle...");
        }

        private void DrawRectangle(Rectangle r)
        {
            Console.WriteLine("painting a rectangle...");
        }
    }
}
