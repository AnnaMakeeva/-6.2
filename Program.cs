using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим строку
            string roza = Console.ReadLine();

            // здесь будет наша перевернутая строка
            string reverseroza = ""; 

            for (int i = roza.Length - 1; i >= 0; i--)
            {
                // переворачиваем строку
                reverseroza += roza[i]; 
            }
            if (roza == reverseroza)
                Console.WriteLine("Введенная строка является палиндромом");
            else
                Console.WriteLine("Введенная строка не является палиндромом");
            Console.ReadKey();
        }
    }
}
