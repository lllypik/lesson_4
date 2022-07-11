using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int stopCycle = n;
            int summ = 0;
            for (int i = 1; i <= stopCycle; i++)
            {
                n = 2 * i - 1;
                summ = summ + n;
                Console.WriteLine(summ);
            }
            System.Console.WriteLine("Квадрат введенного числа N равен " + summ);
            Console.ReadKey();
        }
    }
}
