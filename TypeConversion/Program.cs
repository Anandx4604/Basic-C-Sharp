using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1);
        //Console.Write(typeof(num1)); needs a object

        Console.Write("Enter second number:");
        int num2 = int.Parse(Console.ReadLine()); // Double.Parse cant be used small datatype cant take larger datatype
        Console.WriteLine("Addition of Two Numbers");
        Console.WriteLine(num1+num2);

        Console.Write("\nEnter a double Number:");
        double num3 = double.Parse(Console.ReadLine());
        Console.WriteLine(num3);

        Console.Write("\nEnter Another double Value:");
        double num4 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nAddition of Double Values");
        Console.WriteLine(num3+num4);

        Console.WriteLine("Null Check");
        int num6 = Convert.ToInt32(null);
        Console.WriteLine(num6);

        int num5 = int.Parse(null); //throws exception Error
        Console.WriteLine(num5);


    }
}