using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public abstract class Shape
    {
        private string name;
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }
        public Shape()
        {
            name = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area
        {
           get;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
}