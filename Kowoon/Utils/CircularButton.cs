using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Kowoon.Utils
{
    public class CircularButton : Button
    {
        private GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(rect.X + r2, rect.Y, rect.Width - r2, rect.Y);
            GraphPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(rect.Width, rect.Y + r2, rect.Width, rect.Height - r2);
            GraphPath.AddArc(rect.X + rect.Width - radius,
                             rect.Y + rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(rect.Width - r2, rect.Height, rect.X + r2, rect.Height);
            GraphPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(rect.X, rect.Height - r2, rect.X, rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF rect = new RectangleF(0, 0, Width, Height);
            using (GraphicsPath GraphPath = GetRoundPath(rect, 15))
            {
                Region = new Region(GraphPath);
            }
        }
    }
}
