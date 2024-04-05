using System;
using System.Security.Cryptography.X509Certificates;
namespace MethodPractice;

class Program{

    
    public static void Main(string[] args)
    {
        double a=10; double b=20;

        double result = mul(a,b);
        System.Console.WriteLine(result);


        float num1 =3.4f; float num2 = 4.6f;
        divi(num1,num2);
        

    }

    // with Return with args
    static double mul(double x, double y)
    {
        double c = x*y;
        return c;
    }

    // Without return with args
    static void divi(float i, float j)
    {
        float c = i/j;
        System.Console.WriteLine(c);
    }


}