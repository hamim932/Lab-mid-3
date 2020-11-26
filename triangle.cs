using System;

namespace acount__course
{
    class Program
    {
        static void Main(string[] args)


            class Triangle
        {
            int x;
            int y;
            int z;

            public void ShowInfo()
             {
                Console.WriteLine("x : " + this.x);
                Console.WriteLine("y : " + this.y);
                Console.WriteLine("z : " + this.z);
             }

            public void TestTriangle()
            {
                
                if (x == y && y == z)
                 {
                      Console.WriteLine("The triangle is equilateral");
                  }
                 else if (x == y || y == z || z == x)
                
                 {
                  
                    Console.WriteLine("The triangle is isoscles");
                }
                
                 else
                 
                {
                    Console.WriteLine("The triangle is scalene");
                }
            }
        }
