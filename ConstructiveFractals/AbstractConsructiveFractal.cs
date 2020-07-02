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
        List<PointF> _points = null;

        public float SegmentLenght { get; set; } = 4.0f;

        public IEnumerable<PointF> Points => _points;

        protected abstract IEnumerable<PointF> TransformSegment(PointF point1, PointF point2);

        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            _points = new List<PointF>();
            

            _points.Add(startPoint);
            _points.Add(endPoint);

            for (int i = 0; i < N; i++)
            {
                List<PointF> t = new List<PointF>();
                int count = _points.Count - 1;

                for (int j = 0; j < count; j++)
                {
                    PointF point1 = _points[j + 0];
                    PointF point2 = _points[j + 1];

                    IEnumerable<PointF> temps = TransformSegment(point1, point2);
                    t.AddRange(temps);
                }

                _points = t;
            }

            // TODO:

            return _points;
        }





    }
}
