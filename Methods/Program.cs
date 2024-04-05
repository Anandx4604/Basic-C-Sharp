using System;
using System.Runtime.InteropServices;
namespace Methods;

class Program
{
    public static void Main(string[] args)
    {
        string option = "yes";

        do
        {    

            System.Console.Write("Enter first number:");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.Write("Enter second number:");
            int number2 = int.Parse(Console.ReadLine());



            System.Console.Write("Select an Operation to perform: \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division \nEnter an operation to perform (1 to 4):");
            int operation;

            while(!int.TryParse(Console.ReadLine(),out operation) || operation<1 || operation>4)
            {
                Console.Write("Enter valid Operation(1 to 4):");                
            }

            switch(operation)
            {
                case 1:
                {
                    int result = add(number1, number2);
                    Console.WriteLine($"\nAddition of Two Number:{result}");
                    break;                    
                }

                case 2:
                {
                    int result = sub(number1, number2);
                    Console.WriteLine($"\nSubtraction of Two Number:{result}");
                    break;
                }

                case 3:
                {
                    int result = mul(number1, number2);
                    Console.WriteLine($"\nMultiplication of Two Number:{result}");
                    break;
                }

                case 4:
                {
                    double result = div((double)number1, (double)number2);
                    Console.WriteLine($"\nDivision of Two Number:{result}");
                    break;
                }

                default:
                {
                    System.Console.Write("\nEnter valid Operation! Enter again (1 to 4):");
                    break;
                }

            }

            int add(int x, int y)
            {
                int z = x + y;
                return z;
            }

            int sub(int x, int y)
            {
                int z = x - y;
                return z;
            }

            int mul(int x, int y)
            {
                int z = x * y;
                return z;
            }

            double div(double x, double y)
            {
                double z = x / y;
                return z;
            }

        System.Console.Write("\nDo you want perform again?(yes/no):");
        option = Console.ReadLine();

        }while(option != "no");
        
        

        
    }
}

            