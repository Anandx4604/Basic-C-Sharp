using System;
using System.Diagnostics;
namespace SwitchCase;

class program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Input1 value:");
        int number1= int.Parse(Console.ReadLine());

        Console.Write("Enter The Input2 value:");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter Operation to Perform:");
        //int operation = int.Parse(Console.ReadLine());

        char operation = char.Parse(Console.ReadLine()); 


        switch(operation){
            case '+' :
            {
                int add = number1+number2;
                Console.WriteLine($"Addition:{add}");
                break;
            }

            case '-':
            {
                int sub = number1-number2;
                Console.WriteLine($"Subtraction:{sub}");
                break;
            }

            case '*':
            {
                int mul = number1*number2;
                Console.WriteLine($"Multiplication:{mul}");
                break;
            }

            case '/':
            {
                int div= number1/number2;
                Console.WriteLine($"Dvision:{div}");
                break;
            }
            case '%':
            {
                int mod = number1%number2;
                Console.WriteLine($"Modulus:{mod}");
                break;
            }

            default:
            {
                Console.WriteLine("Invalid");
                break;
            }
        }
    }
}