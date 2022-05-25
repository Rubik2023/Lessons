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

            // Вывод массива строк в цикле
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
            Console.Write("Введите строку: ");
            string inputStr = Console.ReadLine();
            char[] chars = inputStr.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Добавить корабль на игровое поле
        /// </summary>
        /// <param name="field">Игровое поле</param>
        /// <param name="deck">Кол-во палуб</param>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="dir">направление расположения (-1 => горизонтали + вправо/ 1 => вертикали + вниз)</param>
        static void AddShip(char[,] field, int deck, int x, int y, int dir)
        {
            /*
            |.|.|.|.|.|
            |.|.|.|.|.|
            |.|X|X|X|X|
            |.|X|.|.|.|
            |.|X|.|.|.|
            */
            // Проверка возможности добавления корабля, клетки должны быть свободны (O)
            if (field[x, y] != 'O') return;
            for (int i = 1; i < deck; i++)
                if (dir > 0 && (!isCellValid(x + i, y) || 'O' != field[x + i, y])) return;
                else if (dir < 0 && (!isCellValid(x, y + i) || 'O' != field[x, y + i])) return;

            // Добавляем корабль
            field[x, y] = 'X'; // Начальная точка
            for (int i = 1; i < deck; i++)
                if (dir > 0)
                    field[x + i, y] = 'X';
                else
                    field[x, y + i] = 'X';
        }

        /// <summary>
        /// Проверка валидности клетки игрового поля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <returns>Результат проверки</returns>
        private static bool isCellValid(int x, int y) 
        {
            return x >= 0 && x < 10 && y >= 0 && y < 10;
        }
        /// <summary>
        /// *"Морской бой": вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
        /// </summary>
        static void Task4()
        {
            char[,] field = new char[10, 10];
            // Заполним все игровое поле свободными клетками (O)
            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    field[i, j] = 'O';

            // Добавим корабли
            AddShip(field, 4, 0, 0, -1); // Четырехпалубный корабль по горизонтали
            AddShip(field, 3, 2, 5, 1); // Трехпалубный корабль по вертикали
            AddShip(field, 4, 6, 8, 1); // Четырехпалубный корабль по горизонтали

            // Распечатаем игровое поле
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                    Console.Write("{0}  ", field[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey(true);
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
                Console.WriteLine("3 -> Задача 4");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
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
