using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_library
{
    /// <summary>
    /// Класс, описывающий линию на плоскости 
    /// </summary>
    public class Line
    {
        /// <summary>
        /// Точка, принадлежащая линии
        /// </summary>
        public Point A { get; set; }
        /// <summary>
        /// Угловой коэффициент
        /// </summary>
        public double K { get; set; }
        /// <summary>
        /// Смещение относительно оси Oy
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Базовый конструктор линии
        /// </summary>
        /// <param name="p1">Любая точка, принадлежащая нашей прямой</param>
        /// <param name="p2">Любая точка, принадлежащая нашей прямой, но p1 != p2</param>
        public Line(Point p1, Point p2)
        {
            A = new Point(p1.X, p1.Y);

            K = (p2.Y - p1.Y) / (p2.X - p1.X);
            C = p1.Y - K * p1.X;
        }

        /// <summary>
        /// Находит расположение точки относительно линии.
        /// </summary>
        /// <param name="a">Точка, расположение которой мы ищем</param>
        /// <returns>Если (C - c1) > 0, точка находится выше линии;
        /// если (C - c1) = 0, то точка находится на линии; если (C - c1) < 0, то точка находится ниже линии</returns>
        public double FindLocationOfPoint(Point a)
        {
            double c1 = a.Y - this.K * a.X;
            return (C - c1);
        }
    }
}
