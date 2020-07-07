using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class MinkowskiRecursiveFractal : AbstractRecursiveFractal
    {
        protected override IEnumerable<PointF> TransformSegment(PointF point1, PointF point2)
        {
            float d = 0.25f;
            PointF vector = new PointF(point2.X - point1.X, point2.Y - point1.Y);
            PointF[] points = new PointF[7];

            points[0] = new PointF(point1.X + vector.X * 1 * d, point1.Y + vector.Y * 1 * d);
            points[3] = new PointF(point1.X + vector.X * 2 * d, point1.Y + vector.Y * 2 * d);
            points[6] = new PointF(point1.X + vector.X * 3 * d, point1.Y + vector.Y * 3 * d);

            points[1] = new PointF
            {
                X = (points[3].Y - points[0].Y) + points[0].X,
                Y = -(points[3].X - points[0].X) + points[0].Y
            };

            points[2] = new PointF
            {
                X = (points[6].Y - points[3].Y) + points[3].X,
                Y = -(points[6].X - points[3].X) + points[3].Y
            };

            points[4] = new PointF
            {
                X = -(points[6].Y - points[3].Y) + points[3].X,
                Y = (points[6].X - points[3].X) + points[3].Y
            };

            points[5] = new PointF
            {
                X = -(point2.Y - points[6].Y) + points[6].X,
                Y = (point2.X - points[6].X) + points[6].Y
            };

            return new List<PointF>(points);
        }
    }
}
