using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Lesson5
{
    internal class Homework5
    {
        /// <summary>
        /// Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл
        /// </summary>
        static void Task1()
        {
            //string text = "Самое шумное существо в океане - это креветка";
            Console.Write("Введите с клавиатуры произвольный набор данных: ");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\user\Desktop\text.txt", text);   // путь и сам text
            Console.WriteLine("Text was written...");
            Console.ReadKey(true);
        }
        /// <summary>
        /// Написать программу, которая при старте дописывает текущее время в файл «startup.txt»
        /// </summary>
        static void Task2()
        {
            //Console.WriteLine(date1.ToLocalTime()); // 20.07.2015 21:30:25
            //Console.WriteLine(date1.ToUniversalTime()); // 20.07.2015 15:30:25
            //Console.WriteLine(date1.ToLongDateString()); // 20 июля 2015 г.
            //Console.WriteLine(date1.ToShortDateString()); // 20.07.2015
            //Console.WriteLine(date1.ToLongTimeString()); // 18:30:25
            //Console.WriteLine(date1.ToShortTimeString()); // 18:30
            //Console.WriteLine(DateTime.Now);

            File.WriteAllText(@"C:\Users\user\Desktop\startup.txt", DateTime.Now.ToLongTimeString());
            Console.WriteLine("Text was written...");
            Console.ReadKey(true);
        }

        static void Task3()

        {
            /// <summary>
            /// 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            /// </summary>
            /// <param name="args"></param>
            string path = "set.dat"; //передаем путь к файлу, который будет связан с потоком

            // создаем объект BinaryWriter
            using (BinaryWriter Tik = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                Console.Write("Введите с клавиатуры произвольный набор чисел (0...255): ");
                string number = Console.ReadLine();
                Tik.Write("Полученные данные: " + number);   // записываем в файл строку                             
                Console.WriteLine("File has been written");
                Console.ReadKey();
            }
        }
        //static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        //{
        //    Console.Write(indent);
        //    Console.Write(lastDirectory ? "└─" : "├─");
        //    indent += lastDirectory ? " " : "│ ";
        //    Console.WriteLine(dir.Name);

        //    // TODO: Распечать наименования всех файлов
        //    FileInfo[] subFiles = dir.GetFiles();

        //    DirectoryInfo[] subDirs = dir.GetDirectories();
        //    for (int i = 0; i < subDirs.Length; i++)
        //    {
        //        PrintDir(subDirs[i], indent, i == subDirs.Length - 1);
        //    }

        //}

        //static void Task4()
        //{
        //    // Directory, File, FileInfo, DirectoryInfo

        //    DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

        //    Console.WriteLine("FullName: {0}", directoryInfo.FullName);
        //    Console.WriteLine("Name: {0}", directoryInfo.Name);
        //    Console.WriteLine("Parent: {0}", directoryInfo.Parent);
        //    Console.WriteLine("Creation: {0}", directoryInfo.CreationTime);
        //    Console.WriteLine("Attributes: {0}", directoryInfo.Attributes.ToString());
        //    Console.WriteLine("Root: {0}", directoryInfo.Root);

        //    Console.WriteLine();

        //    PrintDir(new DirectoryInfo(@"C:\Users\user\source\Lessons\Lesson5"), "", true);


        //    Console.ReadKey(true);

        //}


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
                //Task4();
            }
        }
    }
}
