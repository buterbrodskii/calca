using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class kvadratniykoren
    {
        public double SquareRoot()
        {
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Ошибка: нельзя извлечь квадратный корень из отрицательного числа.");
                return double.NaN;
            }
            return Math.Sqrt(number);
        }
    }
}
