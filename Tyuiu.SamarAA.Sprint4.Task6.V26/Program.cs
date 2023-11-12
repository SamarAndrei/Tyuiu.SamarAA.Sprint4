using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SamarAA.Sprint4.Task6.V26.Lib;

namespace Tyuiu.SamarAA.Sprint4.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан строковый массив данных [Тюмень, Тамбов, Томск, Омск,               *");
            Console.WriteLine("* Орёл], используя класс Array, выведите элементы массива,                *");
            Console.WriteLine("* длина которых больше 5 символов.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var array = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };

            Console.WriteLine("Исходный массив: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(array);

            for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
