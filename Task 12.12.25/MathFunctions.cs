using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._12._25
{
    internal class MathFunctions
    {
        public static double Mean(double[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                throw new ArgumentException("Необходимо минимум два положительных числа.");
            if (numbers.Any(n => n <= 0))
                throw new ArgumentException("Геометрическое среднее не определяется для отрицательных чисел.N/A (есть <= 0)");

            return numbers.Average();
        }

        public static double Median(double[] numbers)
        {
            var sorted = numbers.OrderBy(n => n).ToArray();
            int n = sorted.Length;
            return (n % 2 == 1) ? sorted[n / 2] : (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
        }

        public static double Mode(double[] numbers)
        {
            return numbers
                .GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key)
                .First().Key;
        }

        public static double StdDev(double[] numbers)
        {
            double mean = numbers.Average();
            double variance = numbers.Average(v => Math.Pow(v - mean, 2));
            return Math.Sqrt(variance);
        }

        public static double GeometricMean(double[] numbers)
        {
            if (numbers.Any(n => n <= 0))
                throw new ArgumentException("Геометрическое среднее не определяется для отрицательных чисел.");
            return Math.Pow(numbers.Aggregate(1.0, (a, b) => a * b), 1.0 / numbers.Length);
        }
    }
}
