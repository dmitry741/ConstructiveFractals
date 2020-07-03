﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    class FractalFactory
    {
        public static IConstructiveFractal GetConstructiveFractal(int index)
        {
            IConstructiveFractal fractal;

            if (index == 0)
                fractal = new KochRecursiveFractals();
            else
                fractal = new DragonRecursiveFractal();

            return fractal;
        }
    }
}
