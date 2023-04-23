using System;

namespace FigureAreaCalculation
{
    public class TriangleCheck
    {
        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным, использую теорему Пифагора.
        /// a, b, c - длины сторон треугольника.
        /// </summary>
        /// <returns>true, если треугольник является прямоугольным</returns>
        public bool Check(double a, double b, double c)
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) ||
                Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) ||
                Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
