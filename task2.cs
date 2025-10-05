using System;

class Program
{
    // Метод для обмена значениями  
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"x = {x}, y = {y}");

        Swap(ref x, ref y); 

        Console.WriteLine($"x = {x}, y = {y}");
    }
}