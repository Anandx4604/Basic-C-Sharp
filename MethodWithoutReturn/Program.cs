// Method with no return

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Second number:");
        int number2 = int.Parse(Console.ReadLine());

        swap(number1, number2);
    }

    static void swap( int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;

        Console.Write("\n");
        Console.WriteLine($"First Number : {a}");
        Console.WriteLine($"Second Number : {b}");


    }

}