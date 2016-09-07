using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NSTest {
    public class MyCanvas : Canvas {

        public const int NROWS = 20;
        public const int NCOLS = 5;

        protected override void OnRender(DrawingContext dc) {
            Size s = this.RenderSize;
            double w, h, x, y;

            Pen p = new Pen(Brushes.Black, 1);
            Pen pred = new Pen(Brushes.Red, 1);
            dc.DrawRectangle(this.Background, new Pen(Brushes.Blue, 1), new Rect(this.RenderSize));

            w = (int)(s.Width / NCOLS);
            for(int i = 0; i < NCOLS; i++) {
                dc.DrawLine(p,
                new Point(i * w, s.Height),
                new Point(i * w, 0));
            }
            h = (int)(s.Height / NROWS);
            for(int i = 0; i < NROWS; i++) {
                dc.DrawLine(p,
                new Point(0, i * h),
                new Point(s.Width, i * h));
            }

            FormattedText ft;
            Typeface tf = new Typeface("Courier New");
            for(int i = 0; i < 100; i++) {
                x = i / NROWS;
                y = i % NROWS;
#if true
                dc.DrawLine(pred,
                        new Point(1 + x * w, 1 + y * h),
                        new Point(  (x+1) * w, 1 + y * h));
#else


                dc.DrawRectangle(Brushes.Red, pred,
                    new Rect(
                        new Point(3+x * w, 3+y * h),
                        new Point((x + 1) * w - 3, (y + 1) * h - 3)));
#endif
                ft = new FormattedText(
                    i.ToString(),
                    CultureInfo.CurrentUICulture,
                    FlowDirection.LeftToRight,
                    tf, 10, Brushes.Black);
//                dc.DrawText(ft, new Point(x * w, y * h));
            }
            //            p.
        }
    }
}