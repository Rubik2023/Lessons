using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Homework2
    {

        /// <summary>
        /// Задание 1.Вывести среднесуточную температуру.
        /// </summary>
        static void Task1()
        {
            Console.Write("Введите минимальную температуру за сутки X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки Y: ");
            int Y = int.Parse(Console.ReadLine());
            Console.Write($"Среднесуточная температура: {(X + Y) / 2}");
            Console.ReadKey();
        }


        /// <summary>
        /// Задание 2.Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        /// </summary>
        static void Task2()
        {

            Console.Write("Введите номер месяца: ");
            int number = int.Parse(Console.ReadLine());
            string monthTitle = "";
            switch (number)
            {
                case 1:
                    monthTitle = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;

            }
            Console.WriteLine(monthTitle);
            Console.ReadKey();

        }
        /// <summary>
        /// Задание 3. Определить, является ли введённое пользователем число чётным.
        /// </summary>
        static void Task3()
        {
            Console.Write("Введите число: ");                  
            int a = int.Parse(Console.ReadLine());            
            if (a % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число нечетное");               
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Задание 4.Схематичная отрисовка чека
        /// </summary>
        static void Task4()
        {
            Console.WriteLine("КАССОВЫЙ ЧЕК");
            string dateTime = "20.06.18 13:05";
            Console.WriteLine($"{ dateTime}");
            string kassir = "Абрамов В.В ";
            Console.WriteLine($"Кассир: {kassir}");
            int cmena = 00003;
            int check = 00003;
            Console.WriteLine($"Смена: {cmena} ЧЕК: {check}");
            string OFD = "ООО.Звотор ОФД";
            Console.WriteLine($"ОФД: {OFD}");
            string site = "www.nalog.ru";
            Console.WriteLine($"Сайт ФНС: {site}");
            string location = "Магазин Николаевский";
            Console.WriteLine($"Место расчетов: {location}");
            string product = "1.000 X 182.00";
            Console.WriteLine($"Шампунь - {product}");
            double total = 182.00;
            Console.WriteLine($"ИТОГ: ={total}");
            double cash = 182.00;
            Console.WriteLine($"НАЛИЧНЫМИ: {cash}");
            Console.WriteLine("ПОЛУЧЕНО: 182");
            Console.ReadLine();
        }

        /// <summary>
        /// Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести
        ///сообщение «Дождливая зима».
        /// </summary>
        static void Task5()
        {
            {
                Console.Write("Введите минимальную температуру за месяц X: ");
                int X = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальную температуру за месяц Y: ");
                int Y = int.Parse(Console.ReadLine());
                int XY = (X + Y) / 2;
                Console.WriteLine($"Среднемесячная температура: {XY}");
                Console.Write("Введите номер месяца: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1 || number == 2 || number == 12)
                {
                    if (XY > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    else
                    {
                        Console.WriteLine($"Зима не будет дождливой.");
                    }

                    Console.ReadKey();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Мои задачи");
            Console.WriteLine("=================================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("2 -> Задача 2");
            Console.WriteLine("3 -> Задача 3");
            Console.WriteLine("4 -> Задача 4");
            Console.WriteLine("5 -> Задача 5");
            Console.WriteLine("0 -> Завершение работы приложения");
            Console.WriteLine("=================================");

            Console.Write("Введите номер задачи: ");
            int number = int.Parse(Console.ReadLine());


            switch (number)
            {
                case 5:
                    Task5();
                    break;
                case 4:
                    Task4();
                    break;
                case 3:                   
                    Task3();
                    break;
                case 2:
                    Task2();
                    break;
                case 1:
                    Task1();
                    break;
                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;  
                    
                default:
                    Console.WriteLine("Некорректный номер задачи,\nповторите попытку ввода ...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
