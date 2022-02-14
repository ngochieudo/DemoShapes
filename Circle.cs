using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class Circle : Shape
    {
        public int Radius { get; set;}
        public Circle() : base("Circle")
        {
            Radius = 1;
        }
        public Circle(string name, int radius) : base(name)
        {
            Radius = radius;
        }
        public override double Area
        {
            get { return 3.14 * Radius * Radius; }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Radius: " + Radius);
        }
    }
}