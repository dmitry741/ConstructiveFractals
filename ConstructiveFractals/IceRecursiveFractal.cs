using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class IceRecursiveFractal : AbstractRecursiveFractal
    {
        protected override IEnumerable<PointF> TransformSegment(PointF point1, PointF point2)
        {
            const float d1 = 0.5f;
            const float d2 = 1.0f / 3.0f;
            PointF vector = new PointF(point2.X - point1.X, point2.Y - point1.Y);
            PointF[] points = new PointF[3];

            points[0] = new PointF(point1.X + vector.X * d1, point1.Y + vector.Y * d1);
            points[2] = points[0];

            PointF prepare = new PointF(point1.X + vector.X * (d1 + d2), point1.Y + vector.Y * (d1 + d2));

            points[1] = new PointF
            {
                X = (prepare.Y - points[0].Y) + points[0].X,
                Y = -(prepare.X - points[0].X) + points[0].Y
            };

            return new List<PointF>(points);
        }
    }
}
