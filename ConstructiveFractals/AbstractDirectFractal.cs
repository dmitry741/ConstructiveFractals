﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class AbstractDirectFractal : IConstructiveFractal
    {
        public IEnumerable<PointF> Build(int N, PointF startPoint, PointF endPoint)
        {
            throw new NotImplementedException();
        }
    }
}