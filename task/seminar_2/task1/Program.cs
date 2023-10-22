using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
                  Console.Write("Введите значение А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение В");
int numberB = Convert.ToInt32(Console.ReadLine());




    double result = Math.Pow(numberA,numberB);
  
    
    Console.WriteLine(result);
        }
    }
}
