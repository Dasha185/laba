
using System;

class Program
{ 
    static int FindMax(int a, int b)
    {
        return a > b ? a : b;
    }

    static void Main()
    {
        int a, b;

        Console.WriteLine("Введите первое число: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        b = int.Parse(Console.ReadLine());

        int maxNumber = FindMax(a, b);

        Console.WriteLine($"Наибольшее число: {maxNumber}");

      
    }
}


