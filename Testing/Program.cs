using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] ones = new string[]{"zero","one","two","three","four","five","six","seven","eight","nine"};
        string[] teen = new string[]{"ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
        string[] twos = new string[]{"","","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};

        int number =int.Parse(Console.ReadLine());

        int i = number;
    
        if(number<10)
        {
            number=i;
            Console.WriteLine(ones[i]);
        }

        else if(number<20)
        {
            Console.WriteLine(teen[number-10]);                  
        }

        else if(number<100)
        {
            int two =number/10;
            int one = number%10;
            
            if(one==0)
            {
                System.Console.WriteLine(twos[two]);
            }
            else
            {
                System.Console.Write(twos[two]+ " " +ones[one]);

            }

        }
        
        else if(number==100)
        {
            System.Console.WriteLine("Hundred");
        }

        else
        {
            System.Console.WriteLine("Invalid! Enter number from 1 to 100");
        }

    }
}