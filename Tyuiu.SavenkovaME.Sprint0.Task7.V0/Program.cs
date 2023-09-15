using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint0.Task7.V0.Lib;

namespace Tyuiu.SavenkovaME.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Спринт #0 | Выполнила Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #0                                                       *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                     *");
            Console.WriteLine("* Задание #7                                                      *");
            Console.WriteLine("* Вариант #0                                                      *");
            Console.WriteLine("* Выполнила: Савенкова Мария Евгеньевна : ИИПб-23-2               *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                        *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения *");
            Console.WriteLine("* двух одинаковых массивов по длине.                              *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");
            Console.WriteLine("*******************************************************************");

            int[] Arraysnum1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения элементов массива №1");
            for (var i = 0; i < Arraysnum1.Length; i++)
            {
                Console.Write(Arraysnum1[i] + ", ");
            }
            Console.WriteLine();

            int[] Arraysnum2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения элементов массива №1");
            for (var i = 0; i < Arraysnum2.Length; i++)
            {
                Console.Write(Arraysnum1[i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");
            if (Arraysnum1.Length == Arraysnum2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(Arraysnum1, Arraysnum2);
                Console.WriteLine("Сумма элементов массива равна: ");
                for (var i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов.");
            }
            Console.ReadKey();
        }
    }
}
