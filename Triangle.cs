using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class Triangle : Shape
    {
        private int A { get; set; }
        private int B { get; set; }
        private int C { get; set; }

        public Triangle() : base("Triangle")
        {
            A = 1;
            B = 2;
            C = 3;
        }
        public Triangle(string name, int a, int b, int c) : base(name)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Area
        {
            get 
            {
                double p = (A + B + C) / 2.0;
                double s = Math.Sqrt(p * (p-A) * (p-B) * (p-C));
                return s;
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side 1: " + A);
            Console.WriteLine("Side 2: " + B);
            Console.WriteLine("Side 3: " + C);
        }

    }
}