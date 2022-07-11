using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите положительное число А");
            int edgeA = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите положительное число B");
            int edgeB = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите положительное число C");
            int edgeC = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 0;
            //проверка правильности данных
            if ( ( edgeA - edgeC ) < 0 && (edgeB - edgeC) < 0)
            {
                System.Console.WriteLine("Количество квадратов со стороной С, помещаемых в прямоугольнике со сторанами АхВ: 0");
            }
            //Основной цикл
            else
            {
                int fixEdgeA = edgeA;
                int fixEdgeB = edgeB;
                while (edgeA >= edgeC)
                {
                    edgeA = edgeA - edgeC;
                    i++;
                }
                while (edgeB >= edgeC)
                {
                    edgeB = edgeB - edgeC;
                    j=j+i;
                }
                
            }
            System.Console.WriteLine("Количество квадратов со стороной С, помещаемых в прямоугольнике со сторанами АхВ: " + j);
            Console.ReadKey();
        }
    }
}
