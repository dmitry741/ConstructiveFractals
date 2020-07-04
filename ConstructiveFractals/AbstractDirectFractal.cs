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
        double[] _angle = null;
        float[] _lenght = null;

        private static Stack<int> ConvertNumericSystem(int value, int baseSystem)
        {
            return null;
        }

        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
