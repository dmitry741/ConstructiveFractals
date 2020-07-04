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

        private static Stack<int> ConvertNumericSystem(int v, int baseSystem)
        {
            Stack<int> stack = new Stack<int>();
            int b = v, r;

            while (true)
            {                
                r = b % baseSystem;
                b /= baseSystem;

                stack.Push(r);

                if (b < baseSystem)
                {
                    stack.Push(b);
                    break;
                }
            }

            return stack;
        }

        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
