using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class KochDirectFractals : AbstractDirectFractal
    {
        public KochDirectFractals()
        {
            _fragmentsPerStep = 4;
            _lenghts = new float[_fragmentsPerStep];
            _angles = new double[_fragmentsPerStep];

            _angles[0] = _angles[3] = 0;
            _angles[1] = Math.PI / 3;
            _angles[2] = -Math.PI / 3;

            _lenghts[0] = _lenghts[1] = _lenghts[2] = _lenghts[3] = 1.0f / 3.0f;
        }
    }
}
