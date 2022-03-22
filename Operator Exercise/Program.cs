using System;

namespace Operator_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For division, create two integer variables called a and b.

            int a = 17;
            int b = 4;
            
            int sum = a + b;

            int diff = a - b;

            int product = a * b;

            double quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {diff}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder is {remainder}");

            Console.WriteLine();
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI / Math.Pow(radius, 2);

            Console.WriteLine($"The area is: {circleArea}");

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);
            Console.WriteLine(j);


          
        }
        
        
    




            

           
    }
}
