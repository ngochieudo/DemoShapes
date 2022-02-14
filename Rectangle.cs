using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Rectangle() : base("Rectangle")
        {
            width = 1;
            height = 2;
        }
        public Rectangle(string name, int width, int height) : base(name)
        {
            Width = width;
            Height = height;
        }
        public override double Area
        {
            get { return Width * Height; }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
        }
    }
}