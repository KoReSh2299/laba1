using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1_library;

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isrunning = true;
            int choose;
            Rhombus rhombus = new Rhombus();
            Point point;
            while (isrunning)
            {
                Console.Clear();
                Console.WriteLine("             Меню");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("| 1. Создать ромб             |");
                Console.WriteLine("| 2. Найти длины сторон ромба |");
                Console.WriteLine("| 3. Найти периметр ромба     |");
                Console.WriteLine("| 4. Найти площадь ромба      |");
                Console.WriteLine("| 5. Проверить находиться ли  |");
                Console.WriteLine("|    точка внутри ромба       |");
                Console.WriteLine("| 6. Завершить программу      |");
                Console.WriteLine("-------------------------------");

                choose = int.Parse((Console.ReadLine() ?? "0"));

                switch (choose)
                {
                    case 1:
                        Point[] points = new Point[4];

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Точка №{i + 1}: ");
                            Console.Write("x = ");
                            double x = double.Parse(Console.ReadLine() ?? "0");
                            Console.Write("y = ");
                            double y = double.Parse(Console.ReadLine() ?? "0");
                            points[i] = new Point(x, y);
                        }

                        rhombus = new Rhombus(points[0], points[1], points[2], points[3]);

                        if (rhombus.IsExist())
                        {
                            Console.WriteLine("Ромб успешно создан");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        if (rhombus.IsExist())
                        {
                            Console.WriteLine($"Длины сторон \nAB = {Point.GetLen(rhombus.A, rhombus.B)} \n" +
                                              $"BC = {Point.GetLen(rhombus.B, rhombus.C)} \n" +
                                              $"CD = {Point.GetLen(rhombus.C, rhombus.D)} \n" +
                                              $"DA = {Point.GetLen(rhombus.D, rhombus.A)}");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        if (rhombus.IsExist())
                        {
                            Console.WriteLine($"Периметр ромба = {rhombus.Perimeter()}");
                            Console.ReadLine();
                        }
                        break;

                    case 4:
                        if (rhombus.IsExist())
                        {
                            Console.WriteLine($"Площадь ромба = {rhombus.Square()}");
                            Console.ReadLine();
                        }
                        break;

                    case 5:
                        if (rhombus.IsExist())
                        {
                            Console.Write("Введите координаты точки \nx = ");
                            double x = double.Parse(Console.ReadLine() ?? "0");
                            Console.Write("y = ");
                            double y = double.Parse(Console.ReadLine() ?? "0");

                            point = new Point(x, y);
                            if (rhombus.IsPointInsideRhombus(point))
                                Console.WriteLine("Точка находится внутри ромба");
                            else
                                Console.WriteLine("Точка находится вне ромба");

                            Console.ReadLine();
                        }
                        break;

                    case 6:
                        isrunning = false;
                        break;

                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}