using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            


    Console.Write("Введите трехзначное число");
    int number =  Convert.ToInt32(Console.ReadLine());

    if (number >= 100 && number<=999)
    {
        int digit = number / 10 % 10 ;
        System.Console.WriteLine(digit);
    }

    else
    {
        System.Console.WriteLine("Введено не трехзначное число");
    }


        }
    }
}
