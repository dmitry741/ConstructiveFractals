using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class AbstractDirectFractal : IConstructiveFractal
    {
        protected double[] _angles = null;
        protected double[] _lenghts = null;
        protected  int _fragmentsPerStep = 0;

        private IEnumerable<int> ConvertNumericSystem(int v)
        {
            List<int> list = new List<int>();
            int b = v;

            while (b > 0)
            {                
                list.Add(b % _fragmentsPerStep);
                b /= _fragmentsPerStep;
            }

            return list;
        }

        private double GetAngle(int step)
        {
            IEnumerable<int> numbers = ConvertNumericSystem(step);
            return numbers.Select(n => _angles[n]).Sum();
        }

        private PointF Rotate(PointF point, PointF center, double angle)
        {
            double co = Math.Cos(angle);
            double si = Math.Sin(angle);

            double x = Convert.ToSingle(co * (point.X - center.X) + si * (point.Y - center.Y) + center.X);
            double y = Convert.ToSingle(-si * (point.X - center.X) + co * (point.Y - center.Y) + center.Y);

            return new PointF { X = Convert.ToSingle(x), Y = Convert.ToSingle(y) };
        }

        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            PointF vector = new PointF(startPoint.X - endPoint.X, startPoint.Y - endPoint.Y);
            //double sourceLen = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            float[] lens = _lenghts.Select(x => Convert.ToSingle(Math.Pow(x, N))).ToArray();
            int numberOfSegments = 1;

            for (int i = 0; i < N; i++)
            {
                numberOfSegments *= _fragmentsPerStep;
            }

            PointF second = Rotate(new PointF(startPoint.X + vector.X * lens[0], startPoint.Y + vector.Y * lens[0]), startPoint, GetAngle(0));
            List<PointF> points = new List<PointF> { startPoint, second };

            for (int i = 2; i <= numberOfSegments; i++)
            {
                vector.X = points[i - 1].X - points[i - 2].X;
                vector.Y = points[i - 1].Y - points[i - 2].Y;

                PointF preparePoint = new PointF(points[i - 1].X + vector.X * lens[i % _fragmentsPerStep], (points[i - 1].Y + vector.Y * lens[i % _fragmentsPerStep]));
                points.Add(Rotate(preparePoint, points[i - 1], GetAngle(i)));
            }

            points.Add(endPoint);

            return points;
        }
    }
}
