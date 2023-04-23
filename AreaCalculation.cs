using System;

namespace FigureAreaCalculation
{
    public class AreaCalculation
    {
        /// <summary>
        /// Вычисление площади окружности.
        /// </summary>
        /// <returns>значение площади окружности или -1, если входящие данные некорректны.</returns>
        public double Calculate(double radius)
        {
            if (Check(radius) == false)
                return -1;

            return Math.PI * radius * radius;
        }


        /// <summary>
        /// Вычисление площади прямоугольник.
        /// </summary>
        /// <returns>значение площади прямоугольника или -1, если входящие данные некорректны.</returns>
        public double Calculate(double a, double b)
        {
            if (Check(a, b) == false)
                return -1;

            return a * b;
        }


        /// <summary>
        /// Вычисление площади треугольника по формуле Герона.
        /// a, b, c - длины сторон треугольника.
        /// </summary>
        /// <returns>значение площади треугольника или -1, если входящие данные некорректны.</returns>
        public double Calculate(double a, double b, double c)
        {
            if (Check(a, b, c) == false)
                return -1;

            if (a + b < c || a + c < b || b + c < a)
                return -1;

            double semiperimeter = (a + b + c) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        }

        /// <summary>
        /// Проверка чисел на положительные значения.
        /// </summary>
        /// <returns>true, если все числа массива больше нуля.</returns>
        private bool Check(params double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= 0)
                    return false;
            }

            return true;
        }
    }
}
