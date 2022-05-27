using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Homework4
    {
        /// <summary>
        /// Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
        /// объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль3–4 разных ФИО
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <returns></returns>
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string result = firstName + ' ' + lastName + ' ' + patronymic;
            return result;
        }

        static void Task1()
        {
            int c = 1;

            while (c < 4)
            {
                Console.WriteLine("Введите ваше ФИО: ");
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string patronymic = Console.ReadLine();
                string ФИО;


                ФИО = GetFullName(firstName, lastName, patronymic);
                Console.WriteLine(c++ + ") Привет " + ФИО + "!");
                Console.WriteLine("====================================");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
        /// возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывестирезультат на экран.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        static void Task2()
        {
            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
                                        
        /// <summary>
        /// 
        /// </summary>
        enum season { NaN, Winter, Spring, Summer, Autumn }
        static season OfMonth(int n)
        {
            try
            {
                if (n <= 0 || n > 12)
                    throw new Exception("Ошибка: введите число от 1 до 12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.NaN;
            }
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        static void Task3()
        {
            
                Console.WriteLine("Введите номер месяца: ");
                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
           

        }

            static void Main(string[] args)
            {

            bool f = true;
            while (f)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");               
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    
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
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        return;

                    default:
                        Console.WriteLine("Некорректный номер задачи,\nповторите попытку ввода ...");
                        break;
                }
            }
        }
        
    }
    
}

