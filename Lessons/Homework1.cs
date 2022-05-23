using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Homework1
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)

        {
            Console.Write("Укажите ваше имя: ");
            SayHello(Console.ReadLine());
            Console.ReadKey(true);
        }

        /// <summary>
        /// Вспомогательный метод, выводит на экран приветственное сообщение
        /// </summary>
        /// <param name="name">Ваше имя</param>
        static void SayHello(string name)
        {
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToShortDateString()}.");
        }

    }
}








