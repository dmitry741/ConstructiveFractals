﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructiveFractals
{
    /// <summary>
    /// Класс-фабрика для создания фрактала по исходным данным пользовательского интерфейса.
    /// </summary>
    class FractalFactory
    {
        public static IConstructiveFractal GetConstructiveFractal(int algorithmType, int index)
        {
            IConstructiveFractal fractal;

            if (algorithmType == 0)
            {
                if (index == 0)
                    fractal = new KochRecursiveFractals();
                else
                    fractal = new DragonRecursiveFractal();
            }
            else
            {
                fractal = new KochDirectFractals();
            }

            return fractal;
        }
    }
}