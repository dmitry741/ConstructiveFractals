using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class DragonRecursiveFractal : AbstractRecursiveFractal
    {
        protected override IEnumerable<PointF> TransformSegment(PointF point1, PointF point2)
        {
            float d = Convert.ToSingle(1.0 / (2 * Math.Sqrt(2)));
            PointF vector = new PointF(point2.X - point1.X, point2.Y - point1.Y);
            PointF p = new PointF(point1.X + vector.X *  d, point1.Y + vector.Y * d);

            double angle = Math.PI / 4;

            PointF p1 = new PointF
            {
                X = Convert.ToSingle(Math.Cos(angle) * (p.X - point1.X) + Math.Sin(angle) * (p.Y - point1.Y) + point1.X),
                Y = Convert.ToSingle(-Math.Sin(angle) * (p.X - point1.X) + Math.Cos(angle) * (p.Y - point1.Y) + point1.Y)
            };

            PointF p2 = new PointF(point1.X + vector.X * 0.5f, point1.Y + vector.Y * 0.5f);

            p = new PointF(p2.X + vector.X * d, p2.Y + vector.Y * d);

            angle = -Math.PI / 4;

            PointF p3 = new PointF
            {
                X = Convert.ToSingle(Math.Cos(angle) * (p.X - p2.X) + Math.Sin(angle) * (p.Y - p2.Y) + p2.X),
                Y = Convert.ToSingle(-Math.Sin(angle) * (p.X - p2.X) + Math.Cos(angle) * (p.Y - p2.Y) + p2.Y)
            };

            return new List<PointF>
            {
                p1, p2, p3
            };
        }
    }
}
