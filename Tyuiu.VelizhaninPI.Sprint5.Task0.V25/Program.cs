using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint5.Task0.V25.Lib;
using Tyuiu.VelizhaninPI.Sprint5.Task0.V25.Test;

namespace Tyuiu.VelizhaninPI.Sprint5.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y(x) = (3x^4 + 1)/x^3:                                   *");
            Console.WriteLine("* вычислить его значение при x = 3, результат сохранить в текстовый файл  *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до трёх             *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadLine();
        }
    }
}
