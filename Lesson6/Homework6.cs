using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6
{
    internal class Homework6
    {
        static void Main(string[] args)
        {

            var procList = Process.GetProcesses();
            foreach (var proc in procList)
            {
                Console.WriteLine($"{proc.Id} {proc.ProcessName} {proc.BasePriority}");
            }
            Console.Write("Запущеный процесс = ");
            var name = Console.ReadLine();
            try
            {
                procList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                Console.WriteLine($"{name} Завершение процесса!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Процесс {name} не найден!");
            }
            Console.ReadKey();
        }
    }
}
