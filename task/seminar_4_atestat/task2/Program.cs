using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

        Console.Write("Введите значение M: ");
        M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных элементов от " +M+ " до " +N+ " равна " +sum);
        }
    }
}
