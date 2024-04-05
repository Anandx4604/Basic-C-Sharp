using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int i = 1;
        int sum =0;

        if(number<10)
        {
            do
            {
            Console.WriteLine(i);
            i++;
            }while(i<number);
        }

        if(number>10)
        {
            do
            {
                int mod = number%10;
                int cube = mod*mod*mod;
                sum+=cube;
                int div = number/10;
                number = div;
                i++;

            }while(i!=number);
            Console.WriteLine(sum);

        }
    }
}