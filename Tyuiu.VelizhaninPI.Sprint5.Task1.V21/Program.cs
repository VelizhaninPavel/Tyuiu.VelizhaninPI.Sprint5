using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint5.Task1.V21.Test;
using Tyuiu.VelizhaninPI.Sprint5.Task1.V21.Lib;

namespace Tyuiu.VelizhaninPI.Sprint5.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (2x - 3)/(cos(x) - 2x) + 5x - sin(x):               *");
            Console.WriteLine("* произвести табулирование F(x) на заданном диапозоне [-5; 5] с шагом 1.  *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл и вывести на консоль в *");
            Console.WriteLine("* таблицу. Значения округлить до двух знаковы после запятой               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadLine();
        }
    }
}
