using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        swap(number1, number2);
    }

    static void swap( int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"First Number : {a}");
        Console.WriteLine($"Second Number : {b}");


    }

    
}
            