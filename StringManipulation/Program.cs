using System;
using System.Globalization;
namespace StringManipulation;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Main string:");
        string testString = Console.ReadLine();


        Console.Write("String to be searched:");
        string subs = Console.ReadLine();



        string[] splitString = testString.Split(subs);
        
        //printing splittted string
        // foreach (string s in splitString)
        // {
        //     Console.WriteLine(s);
        // }

        Console.WriteLine($"string searched count is:{splitString.Length-1}");



    }
}