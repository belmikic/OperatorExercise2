using System;

namespace OperatorExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var AreaOfCircle = Math.PI * (radius * radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle}");
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
            //++i =4, j++=4, first one is prefix, the second one is a post so k =16
            

        }

            public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }

            }
        

    







    

}



        
        
    




