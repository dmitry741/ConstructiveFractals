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

        private IEnumerable<int> ConvertNumericSystem(int v, int baseSystem)
        {
            List<int> list = new List<int>();
            int b = v;

            while (b > 0)
            {                
                list.Add(b % baseSystem);
                b /= baseSystem;
            }

            return list;
        }

        private double GetAngle(int step, int baseSystem)
        {
            IEnumerable<int> numbers = ConvertNumericSystem(step, baseSystem);
            return numbers.Select(n => _angle[n]).Sum();
        }

        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
