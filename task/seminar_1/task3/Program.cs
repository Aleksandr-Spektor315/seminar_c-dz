using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.Write("Введите день нидели");
           int day = Convert.ToInt32(Console.ReadLine());
           if(day >= 1 && day <=5)
           {
            System.Console.WriteLine("Нет");
           }
           else if (day == 6 || day ==7)
           {
            System.Console.WriteLine("да");
           }
           else
           {
            System.Console.WriteLine("Такого дня недели не существует");
           }
        }
    }
}
