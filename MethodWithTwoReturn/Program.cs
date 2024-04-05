using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter First number:");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Second number:");
                int number2 = int.Parse(Console.ReadLine());

                swap(out number1,out number2, number1, number2);

                Console.WriteLine($"First Number : {number1}");
                Console.WriteLine($"Second Number : {number2}");

            }

            static void swap(out int a, out int b, int originalA, int originalB)
            {
                a = originalB;
                b = originalA;
            }

            
        }
            