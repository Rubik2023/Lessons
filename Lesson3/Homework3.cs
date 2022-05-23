using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Homework3
    {

        /// <summary>
        /// Написать программу, выводящую элементы двумерного массива по диагонали.
        /// </summary>
        static void Task1()
        {
            int next_string = 0;
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = next_string + 1;
                    Console.WriteLine($"{new string(' ', next_string)}{array[i, j]}");
                    next_string++;
                }
            }          
            Console.ReadLine();
        }
        /// <summary>
        /// Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: 
        /// первый элемент хранит имя контакта, второй — номер телефона/email.
        /// </summary>
        static void Task2()
        {

            string[,] arr = new string[5, 2]
             { { "Kelli", "+7..3234" }, { "Tom", "+7..1334" },
             { "Djo", "+7..6734" },{ "Ben", "+7..8734" },
             { "Olli", "+7..3456" } };

            // Вывод массива строк AS в цикле
            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.Write(arr[y, x] + "\t");
                }
                Console.WriteLine();
            }          
            Console.ReadLine();

        }
        /// <summary>
        /// Задание 3.Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
        /// </summary>
        static void Task3()
        {
            Console.Write("SayHello: ");
            string chararray = Console.ReadLine();
            for (int i = chararray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{ chararray[i]}\t");
            }
            Console.ReadLine();
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
