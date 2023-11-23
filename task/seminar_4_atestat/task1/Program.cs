using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Numbers(n);
    }

    static void Numbers(int n)
    {
        if (n <= 0)
        {
            return;
        }
        else
        {
            Console.Write(n + " "); 
            Numbers(n - 1); 
        }
        }
    }
}
