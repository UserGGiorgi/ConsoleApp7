using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Triangle
    {
        public int a { get; set; } 
        public int b { get; set; }
        int c;
        public int C
        {
            get { return c; }
            set
            {
                    c = value;
                
            }
         }

        public  int perimeter()
        {
            int d = a + b + C;
            return d ;

        }

        public  double area()
        {
            int s = (a + b + C) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - C));

            return area;
        }
    }
}
