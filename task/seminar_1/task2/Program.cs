using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.Write("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99)
    {
    while (number > 999)
    {
        number /=10;
    }
    System.Console.WriteLine(number % 10);

    }    
    else
   {
   System.Console.WriteLine("Ошибка");
   }  
        }
    }
}
