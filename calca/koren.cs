using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class koren
    {
        public double Square()
        {
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(number, 2);
        }
    }
}
