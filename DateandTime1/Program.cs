using System;
using System.Security.Cryptography;

public class Program
        {
            public static void Main(string[] args)
            {
               //DateTime birthday = DateTime.Parse(Console.ReadLine());

                //DateTime birthday = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null,System.Globalization.DateTime.Styles.None, out dates);

               DateTime birthday;
               DateTime today;
               bool isValid = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out birthday);

               bool check = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out today);

            //    DateTime today = DateTime.Parse(Console.ReadLine());

               //Console.WriteLine(today);

               TimeSpan age =today-birthday;

               int aged = age.Days/365;

               //int hours = age.Hours/60;


               Console.WriteLine($"Age : {aged}");

               Console.WriteLine($"Day : {birthday.DayOfWeek}");

               Console.WriteLine($"Number of days : {age.Days}");

               Console.WriteLine($"Number of hours : {Math.Round(age.TotalHours)}");

               Console.WriteLine($"Number of minutes : {Math.Round(age.TotalMinutes)}");


            }
        }            