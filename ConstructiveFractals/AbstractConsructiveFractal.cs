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
    abstract class AbstractConsructiveFractal
    {
        public float SegmentLenght { get; set; } = 4.0f;

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
                int count = points.Count - 1;

                for (int j = 0; j < count; j++)
                {
                    t.Add(points[j + 0]);
                    t.AddRange(TransformSegment(points[j + 0], points[j + 1]));                  
                }

                t.Add(endPoint);
                points = t;
            }

            return points;
        }
    }
}
