using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{   
    /// <summary>
    /// Абстрактный класс конструтивного фрактала.
    /// </summary>
    abstract class AbstractRecursiveFractal : IConstructiveFractal
    {
        protected abstract IEnumerable<PointF> TransformSegment(PointF point1, PointF point2);

        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            List<PointF> points = new List<PointF>
            {
                startPoint,
                endPoint
            };

            for (int i = 0; i < N; i++)
            {
                List<PointF> t = new List<PointF>();

                for (int j = 0; j < points.Count - 1; j++)
                {
                    t.Add(points[j]);
                    t.AddRange(TransformSegment(points[j + 0], points[j + 1]));             
                }

                t.Add(endPoint);
                points = t;
            }

            return points;
        }
    }
}
