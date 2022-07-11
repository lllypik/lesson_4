using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Программа для подcчета количества чисел. Счет закончится после ввода числа 0");
            System.Console.WriteLine("Введите целое число");
            int positive = 0;
            int negative = 0;
            int n = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0) positive++;
                if (n < 0) negative++;
            } while (n != 0);
            System.Console.WriteLine("Количество положительных чисел: {0}, количество отрицательных чисел: {1}", positive, negative);
            Console.ReadKey();
        }
    }
}
