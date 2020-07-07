using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class MinkowskiDirectFractal : AbstractDirectFractal
    {
        public MinkowskiDirectFractal()
        {
            _fragmentsPerStep = 8;
            _lenghts = new float[_fragmentsPerStep];
            _angles = new double[_fragmentsPerStep];

            _angles[0] = 0;
            _angles[1] = Math.PI / 2;
            _angles[2] = 0;
            _angles[3] = -Math.PI / 2;
            _angles[4] = -Math.PI / 2;
            _angles[5] = 0;
            _angles[6] = Math.PI / 2;
            _angles[7] = 0;

            for (int i = 0; i < _fragmentsPerStep; i++)
                _lenghts[i] = 0.25f;
        }
    }
}
