using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class SierpinskiTriangle : AbstractRecursiveFractal
    {    
        protected override IEnumerable<PointF> TransformSegment(PointF point1, PointF point2)
        {
            PointF ps1, ps2;

            if (_iteration % 2 == 0)
            {
                ps1 = point1;
                ps2 = point2;
            }
            else
            {
                ps1 = point2;
                ps2 = point1;
            }            

            PointF vector = new PointF(ps2.X - ps1.X, ps2.Y - ps1.Y);
            PointF anchor = new PointF(ps1.X + vector.X * 0.5f, ps1.Y + vector.Y * 0.5f);
            double angle = Math.PI / 3;

            PointF p1 = new PointF
            {
                X = Convert.ToSingle(Math.Cos(angle) * (anchor.X - ps1.X) + Math.Sin(angle) * (anchor.Y - ps1.Y) + ps1.X),
                Y = Convert.ToSingle(-Math.Sin(angle) * (anchor.X - ps1.X) + Math.Cos(angle) * (anchor.Y - ps1.Y) + ps1.Y)
            };

            PointF p2 = new PointF(p1.X + vector.X * 0.5f, p1.Y + vector.Y * 0.5f);

            var result = (_iteration % 2 == 0) ? new List<PointF> { p1, p2 } : new List<PointF> { p2, p1 };

            _iteration++;

            return result;
        }
    }
}
