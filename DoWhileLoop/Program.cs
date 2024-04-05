using System;
using System.Runtime.InteropServices;
namespace DoWhileLoop;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Console.Write("Do you want to find The number is Odd or Even");
        // string option = Console.ReadLine();

        string option;



        do
        {       
            if(number%2==0)
            {
                Console.WriteLine("Given number is Even");
            }

            else
            {
                Console.WriteLine("Given Number is Odd");
            }

        

        Console.Write("Do you want Check another Number? yes/no:");
        option = Console.ReadLine();

            if(option != "yes" && option != "no")
            {
                    System.Console.WriteLine("Invalid");
                    Console.Write("Give a valid input option(yes/no):");
                    option = Console.ReadLine();
            }


            if(option == "yes")
            {
                Console.Write("Enter number again:");
                number = int.Parse(Console.ReadLine());
            }

        }while(option == "yes");  
    }
}