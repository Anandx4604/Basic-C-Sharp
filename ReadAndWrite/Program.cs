using System;
namespace ReadAndWrite;
class Program{
    public static void Main(string[] args)
    {   
        Console.Write("Enter your Name:");
        //Getting inputs
        string name = Console.ReadLine();

        Console.Write("Enter your Father Name:");
        string fatherName = Console.ReadLine();

        //printing results
        //Concatenation
        Console.WriteLine("Concatenation");
        Console.WriteLine(name + " " + fatherName);

        //Placeholder
        Console.WriteLine("\nPlaceholder");
        
        Console.WriteLine("{0} {1}" ,name,fatherName);
        Console.WriteLine("{0} {1}" ,fatherName,name);
        Console.WriteLine("{1} {0}" ,name,fatherName);

        //Interpolation
        Console.WriteLine($"{name} {fatherName}");

        Console.ReadKey();
    }
}