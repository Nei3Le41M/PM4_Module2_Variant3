using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._12._25
{
    internal class TestRunner
    {
        public static void RunAll()
        {
            Console.WriteLine("=== Запуск тестов ===");

            RunTest("Нормальный набор данных", new double[] { 2, 4, 4, 4, 5, 5, 7, 9 });
            RunTest("Один элемент", new double[] { 5 });
            RunTest("Пустой массив", new double[] { });
            RunTest("Отрицательные числа", new double[] { -2, 4, 6 });
            RunTest("Точность вычислений", new double[] { 1.5, 2.5, 3.5, 4.5 });
        }

        private static void RunTest(string name, double[] data)
        {
            Console.WriteLine($"\n▶ {name}");
            try
            {
                double mean = MathFunctions.Mean(data);
                double median = MathFunctions.Median(data);
                double mode = MathFunctions.Mode(data);
                double std = MathFunctions.StdDev(data);
                double geom = MathFunctions.GeometricMean(data);

                Console.WriteLine($"  Среднее: {mean:F3}");
                Console.WriteLine($"  Медиана: {median:F3}");
                Console.WriteLine($"  Мода: {mode:F3}");
                Console.WriteLine($"  Геом. среднее: {geom:F3}");
                Console.WriteLine($"  Ст. отклонение: {std:F3}");
                Console.WriteLine($"  Успешно");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Ошибка: {ex.Message}");
            }
        }
    }
}
