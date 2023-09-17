using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_library
{
    /// <summary>
    /// Класс, описывающий ромб
    /// </summary>
    public class Rhombus : Figure
    {
        /// <summary>
        /// Вершина A
        /// </summary>
        public Point A;
        /// <summary>
        /// Вершина B
        /// </summary>
        public Point B;
        /// <summary>
        /// Вершина C
        /// </summary>
        public Point C;
        /// <summary>
        /// Вершина D
        /// </summary>
        public Point D;

        /// <summary>
        /// Конструктор ромба
        /// </summary>
        /// <param name="a">Вершина А</param>
        /// <param name="b">Вершина B</param>
        /// <param name="c">Вершина C</param>
        /// <param name="d">Вершина D</param>
        public Rhombus(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        /// <summary>
        /// Базовый конструктор для несозданного ромба
        /// </summary>
        public Rhombus() 
        {
            A = B = C = D = null;
        }

        /// <summary>
        /// Проверка на существование Ромба
        /// </summary>
        /// <returns></returns>
        public bool IsExist() 
        {
            // Если ромб ещё не создан 
            if (A != null && B != null && C != null && D != null)
            {
                // Если все стороны равны и 1 из углов между диагоналями равен 90 градусов
                if ((Point.GetLen(A, B) == Point.GetLen(B, C))
                    && (Point.GetLen(B, C) == Point.GetLen(C, D))
                    && (Point.GetLen(C, D) == Point.GetLen(D, A))
                    && (Math.Floor((Math.Pow((Point.GetLen(A, C) / 2), 2) + Math.Pow((Point.GetLen(B, D) / 2), 2)))
                    == Math.Floor(Math.Pow((Point.GetLen(A, B)), 2))))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Данная фигура не является ромбом. Пожалуйста, создайте фигуру заново.");
                    Console.ReadLine();
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Вы ещё не создали фигуру");
                Console.ReadLine();
                return false;
            }
        }

        /// <summary>
        /// Вычисляет периметр ромба
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return (4 * Point.GetLen(this.A, this.B));
        }

        /// <summary>
        /// Вычисляет площадь ромба
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            return (Point.GetLen(this.A, this.C) * Point.GetLen(this.B, this.D) / 2);
        }

        /// <summary>
        /// Проверяет находится ли точка внутри ромба или нет
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsPointInsideRhombus(Point point)
        {
            Line[] sides = new Line[4]
            {
                new Line(A, B),
                new Line(B, C),
                new Line(C, D),
                new Line(D, A),
            };

            if ((sides[0].FindLocationOfPoint(point) >= 0 && sides[2].FindLocationOfPoint(point) <= 0)
                || (sides[0].FindLocationOfPoint(point) <= 0 && sides[2].FindLocationOfPoint(point) >= 0))
            {
                if ((sides[1].FindLocationOfPoint(point) >= 0 && sides[3].FindLocationOfPoint(point) <= 0)
                || (sides[1].FindLocationOfPoint(point) <= 0 && sides[3].FindLocationOfPoint(point) >= 0))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
