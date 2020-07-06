using System;
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
                else if (index == 1)
                    fractal = new DragonRecursiveFractal();
                else
                    fractal = new IceRecursiveFractal();
            }
            else
            {
                if (index == 0)
                    fractal = new KochDirectFractals();
                else if (index == 1)
                    fractal = new DragonDirectFractal();
                else
                    fractal = new IceDirectFractal();
            }

            return fractal;
        }
    }
}
