using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_library
{
    /// <summary>
    /// Класс, описывающий точку на координатной плоскости
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Координата по оси Ox
        /// </summary>
        public double X;
        /// <summary>
        /// Координата по оси Oy
        /// </summary>
        public double Y;
        
        /// <summary>
        /// Конструктор точки
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        public Point(double x, double y) 
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Находит расстояние между двумя точками
        /// </summary>
        /// <param name="a">Точка a</param>
        /// <param name="b">Точка b</param>
        /// <returns>Расстояние между 2-мя точками</returns>
        public static double GetLen(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }
    }
}
