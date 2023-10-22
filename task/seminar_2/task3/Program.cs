using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[b];


        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }


        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        }
    }
}
