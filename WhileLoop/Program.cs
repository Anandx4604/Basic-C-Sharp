//Create a while loop that print 0 to 25 even numbers

using System;
namespace WhileLoop;

class Program{
    public static void Main(string[] args)
    {
        //Exercise-1
        Console.WriteLine("Even Numbers from 0 to 25:");
        int number = 0;

        while(number<26)
        {
            if(number%2==0)
            {
                Console.WriteLine(number);
            }
            number++;
        }

        Console.Write("Enter a valid number:");
        //int validNumber = int.Parse(Console.ReadLine());

        bool isValid = int.TryParse(Console.ReadLine(),out int output);

        while(!isValid)
        {
            Console.Write("Invalid input format. Please enter the input in number format:");
            isValid = int.TryParse(Console.ReadLine(),out output);
        }
    }
}