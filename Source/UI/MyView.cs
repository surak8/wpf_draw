using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace NSTest {
    public class MyView : UIElement {

        protected override void OnRender(DrawingContext dc) {
            dc.DrawRectangle(Brushes.Green, new Pen(Brushes.Purple, 1), new Rect(this.RenderSize));
            base.OnRender(dc);
//            Trace.WriteLine("here");
        }
    }
}