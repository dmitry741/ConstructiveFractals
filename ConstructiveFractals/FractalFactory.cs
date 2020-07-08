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
        /// <summary>
        /// Создание экземпляра фрактала по исходным данным пользовательского интерфейса.
        /// </summary>
        /// <param name="index">Индекс в выпадающем списке.</param>
        /// <returns>IConstructiveFractal объект.</returns>
        public static IConstructiveFractal GetConstructiveFractal(int index)
        {
            IConstructiveFractal fractal;

            if (index == 0)
                fractal = new KochRecursiveFractals();
            else if (index == 1)
                fractal = new MinkowskiRecursiveFractal();
            else if (index == 2)
                fractal = new DragonRecursiveFractal();
            else
                fractal = new IceRecursiveFractal();

            return fractal;
        }
    }
}
