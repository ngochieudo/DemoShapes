using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class TriangleProgram : MenuProgram
    {
        private List<Triangle> listTriangles;
        public TriangleProgram()
        {
            listTriangles = new List<Triangle>();
        }
        public List<Triangle> ListTriangles
        {
            get { return listTriangles; }
        }
        protected override void PrintMenu()
        {
            Console.WriteLine("Choose triangle type");
            Console.WriteLine("1. Normal triangle");
            Console.WriteLine("2. Iso triangle");
            Console.WriteLine("3. Equal triangle");
            Console.WriteLine("0. To shape menu");
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: AddNormalTriangle(); break;
                case 2: AddEqualTriangle(); break;
                case 3: AddIsoTriangle(); break;
                case 0: break;
                default: ShowError(); break;
            }
        }
        private void AddNormalTriangle()
        {
            Console.WriteLine("Enter normal triangle");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter side A length: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side B length: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side C length: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Triangle t = new Triangle(name, a, b, c);
            listTriangles.Add(t);
            Console.WriteLine("Add triangle successful!");


        }
        private void AddEqualTriangle()
        {
            Console.WriteLine("Enter equilateral triangle");
            Console.WriteLine("Enter triangle name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter side length: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Triangle t = new Triangle(name, side, side, side);
            listTriangles.Add(t);
            Console.WriteLine("Add triangle successful!");
        }
        private void AddIsoTriangle()
        {
            Console.WriteLine("Add isosceles triangle");
            Console.WriteLine("Enter triangle name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter side length: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bottom length: ");
            int bottom = Convert.ToInt32(Console.ReadLine());
            Triangle t = new Triangle(name, side, side, bottom);
            listTriangles.Add(t);
            t.ShowInfo();
            Console.WriteLine("Add triangle successful!");
        }
    }
}