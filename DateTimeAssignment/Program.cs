using System;
using System.Data;
using Microsoft.VisualBasic;
namespace DateTimeAssignment;

class Program{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32); //year, month, day, hour,minute,second
        System.Console.WriteLine($"Given Date & Time:{date}");

        System.Console.WriteLine($"Year:{date.Year}");
        System.Console.WriteLine($"Month:{date.Month}");
        System.Console.WriteLine($"Day:{date.Day}");
        System.Console.WriteLine($"Hour:{date.Hour}");
        System.Console.WriteLine($"Minutes:{date.Minute}");
        System.Console.WriteLine($"Seconds:{date.Second}");

        //Convert the Datetime to string.

        DateTime date1;
        System.Console.Write("\nEnter Date & Time(yyyy/MM/dd hh:mm:ss tt):");
        bool isValid = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out date1);

        while(!isValid)
        {
            System.Console.WriteLine("\nInvalid, Give in Correct Format(yyyy/MM/dd hh:mm:ss tt):");
            isValid = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None, out date1);
        }
        
        string sdate = date1.ToString("yyyy/MM/dd hh:mm:ss tt");
        string[] splitDate = sdate.Split(' ', '/',':');

        System.Console.WriteLine("\nReverse String of Date & Time:");

        for(int i =splitDate.Length-1;i>=0;i--)
        {
            System.Console.Write(splitDate[i] + " ");
        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("\nPrinting in String Format:");
        Console.WriteLine($"Year:{date1.ToString("yyyy")}");
        Console.WriteLine($"Month:{date1.ToString("MM")}");
        Console.WriteLine($"Day:{date1.ToString("dd")}");
    }
}