using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckerFunct(m, n);
        Console.WriteLine($"Результат Аккермана для m={m} и n={n} равен {result}");  
        }
         static int AckerFunct(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckerFunct(m - 1, 1);
        }
        else
        {
            return AckerFunct(m - 1, AckerFunct(m, n - 1));
        }
    }
    }
}
