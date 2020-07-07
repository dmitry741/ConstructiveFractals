using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class IceDirectFractal : AbstractDirectFractal
    {
        public IceDirectFractal()
        {
            _fragmentsPerStep = 4;
            _lenghts = new float[_fragmentsPerStep];
            _angles = new double[_fragmentsPerStep];

            _angles[0] = 0;
            _angles[1] = Math.PI / 2;
            _angles[2] = -Math.PI / 2;
            _angles[3] = 0;

            _lenghts[0] = 0.5f;
            _lenghts[1] = 0.33f;
            _lenghts[2] = 0.33f;
            _lenghts[3] = 0.5f;
        }
    }
}
