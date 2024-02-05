using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("Enter Side 1:");
            triangle.a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 2:");
            triangle.b =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Side 3:");
            triangle.C =Convert.ToInt32(Console.ReadLine());

            if (triangle.a + triangle.b <= triangle.C || triangle.a + triangle.C <= triangle.b || triangle.C + triangle.b <= triangle.a)
            {

                Console.WriteLine("Triangle Is Not Valid");

            }
            else
            {
                Console.WriteLine("perimeter:" + triangle.perimeter());
                Console.WriteLine("arrea:" + triangle.area());
            }             
            Console.ReadKey();
        }
    }
}
