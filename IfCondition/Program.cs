﻿using System;
namespace IfCondition;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks:");
        int mark = int.Parse((Console.ReadLine()));

        if(mark>0 && mark<=100){
            if(mark>=80){
                Console.WriteLine("Grade A");
            }
            else if(mark<80 && mark>61){
                Console.WriteLine("Garde B");
            }

            else if(mark<=60 && mark>=36){
                Console.WriteLine("Grade C");
            }

            else if(mark<36){
                Console.WriteLine("Grade D");
            }

        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
    
}