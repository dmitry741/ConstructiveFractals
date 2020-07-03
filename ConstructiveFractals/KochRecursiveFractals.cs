using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class KochRecursiveFractals : AbstractRecursiveFractal
    {
        protected override IEnumerable<PointF> TransformSegment(PointF point1, PointF point2)
        {
            float d = 1.0f / 3.0f;
            PointF vector = new PointF(point2.X - point1.X, point2.Y - point1.Y);

            PointF p1 = new PointF(point1.X + vector.X * 1 * d, point1.Y + vector.Y * 1 * d);
            PointF p3 = new PointF(point1.X + vector.X * 2 * d, point1.Y + vector.Y * 2 * d);

            double angle = Math.PI / 3;

            PointF p2 = new PointF
            {
                X = Convert.ToSingle(Math.Cos(angle) * (p3.X - p1.X) + Math.Sin(angle) * (p3.Y - p1.Y) + p1.X),
                Y = Convert.ToSingle(-Math.Sin(angle) * (p3.X - p1.X) + Math.Cos(angle) * (p3.Y - p1.Y) + p1.Y)
            };

            return new List<PointF>
            {
                p1,
                p2,
                p3
            };
        }
    }
}
