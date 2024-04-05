//Calculate the sum of the square of the numbers present between the two number limit.

using System;
namespace ForLoop;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Second number:");
        int number2 = int.Parse(Console.ReadLine());

        for(int i=number1;i<number2;i++){

            int squaring = (number1 * number1) + (number2 * number2);
            Console.WriteLine($"Square Value:{squaring}");

        }

        
    }
}