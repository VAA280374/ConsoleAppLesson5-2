using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int vMax, vMin;
            for (int i = 0; i < array.Length; i++) 
            { 
                array[i] = random.Next(0, 50);
                Console.WriteLine(array[i]);
            }
            vMax = array[0];
            vMin = array[0];
            for (int i =0; i < array.Length; i++) 
            {
                // Console.WriteLine("Элемент массива номер {0} число {1}", i, array[i]);
                if (vMax < array[i])
                {
                    vMax = array[i];
                }
                if (vMin > array[i])
                {
                    vMin = array[i];
                }
            }
            Console.WriteLine("Сумма максимального и минимального членов массива составляет {0}", (vMax + vMin));
            Console.ReadKey();
        }
    }
}
