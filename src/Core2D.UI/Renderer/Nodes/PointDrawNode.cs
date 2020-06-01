﻿using Core2D.Shapes;
using Core2D.Style;
using Spatial;
using A = Avalonia;
using AM = Avalonia.Media;

namespace Core2D.UI.Renderer
{
    internal class PointDrawNode : DrawNode
    {
        public IPointShape Point { get; set; }
        public double PointSize { get; set; }
        public A.Rect Rect { get; set; }

        public PointDrawNode(IPointShape point, IShapeStyle style, double pointSize)
        {
            Style = style;
            Point = point;
            PointSize = pointSize;
            UpdateGeometry();
        }

        public override void UpdateGeometry()
        {
            ScaleThickness = true; // Point.State.Flags.HasFlag(ShapeStateFlags.Thickness);
            ScaleSize = true; // Point.State.Flags.HasFlag(ShapeStateFlags.Size);
            var rect2 = Rect2.FromPoints(Point.X - PointSize, Point.Y - PointSize, Point.X + PointSize, Point.Y + PointSize, 0, 0);
            Rect = new A.Rect(rect2.X, rect2.Y, rect2.Width, rect2.Height);
            Center = Rect.Center;
        }

        public override void OnDraw(AM.DrawingContext context, double dx, double dy, double zoom)
        {
            context.FillRectangle(Fill, Rect);
            context.DrawRectangle(Stroke, Rect);
        }
    }
}