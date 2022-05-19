using SolidExamples._2_O.Right;
using SolidExamples._2_O.Wrong;

namespace SolidExamples._2_O
{
    public class OpenClosed
    {
        public void Execute()
        {
            //Wrong way
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            GraphicEditor graphicEditor = new GraphicEditor();
            graphicEditor.DrawForm(circle);
            graphicEditor.DrawForm(rectangle);


            //Correct way
            CircleOk circleOk = new CircleOk();
            RectangleOk rectangleOk = new RectangleOk();
            GraphicEditorOk graphicEditorOk = new GraphicEditorOk();
            graphicEditorOk.DrawForm(circleOk);
            graphicEditorOk.DrawForm(rectangleOk);
        }

    }
}
