using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_library
{
    /// <summary>
    /// Абстрактный класс для описания фигур
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Нахождение площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double Square();
        /// <summary>
        /// Нахождение периметра
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        abstract public double Perimeter();
    }
}
