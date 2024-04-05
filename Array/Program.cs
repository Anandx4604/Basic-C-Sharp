using System;
namespace Array;

class Program
{
    public static void Main(string[] args)
    {
        string[] names = new string[]{"Mani","Ganesh","Venkat", "Suresh","Venkat"};

        int i;
        //Printing all names in array

        System.Console.WriteLine("\nPrinting using For Loop:");
        for(i=0;i<names.Length;i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.Write("\nEnter a Name to search:");
        string searchName = Console.ReadLine();


        bool flag = bool.Parse("false");
        for(i=0;i<names.Length;i++)
        {   

            if(names[i] == searchName)
            {
                Console.WriteLine($"The name is present in array and its Index:{i}");
                flag=true;
            }
        }
        if(flag!=true)
            {
                System.Console.WriteLine("The name is not present in array");
            }

        Console.WriteLine("\nUsing Foreach loop:");


        bool flag2 = bool.Parse("false");

        foreach(string j in names)
        {   

            //int count = 0;
            if( j == searchName && flag2 == false)
            {
                Console.WriteLine($"The name is present in array");
                flag2=true;
                //count++;
            }     
        }
        if(flag2 == false)
        {
             System.Console.WriteLine("The name is not present in array");
        }




    }

        
}