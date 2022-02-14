using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class ShapeProgram : MenuProgram
    {
        private List<Shape> listShapes;
        public ShapeProgram()
        {
            listShapes = new List<Shape>();
        }

        protected override void PrintMenu()
        {
            Console.WriteLine("-----SHAPE PROGRAM-----");
            Console.WriteLine("1. Add triangle");
            Console.WriteLine("2. Add square");
            Console.WriteLine("3. Add rectangle");
            Console.WriteLine("4. Add circle");
            Console.WriteLine("5. Show all shapes");
            Console.WriteLine("0. Quit");
            
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: AddTriangle(); break;
                case 2: AddSquare(); break;
                case 3: AddRectangle(); break;
                case 4: AddCircle(); break;
                case 5: ShowAllShapes(); break;
                case 0: break;
                default: ShowError(); break;
            }
        }
        
        private void AddTriangle()
        {
                TriangleProgram tProgram = new TriangleProgram();
                tProgram.Run();
                foreach (Triangle t in tProgram.ListTriangles)
                {
                    listShapes.Add(t);
                }


        }
        private void AddSquare()
        {
            Console.WriteLine("Square information");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter side length: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Square sq = new Square(name, side);
            listShapes.Add(sq);
            sq.ShowInfo();
            Console.WriteLine("Shape added!");

        }
        private void AddRectangle()
        {
            Console.WriteLine("Rectangle information");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Rectangle r = new Rectangle(name, width, height);
            listShapes.Add(r);
            r.ShowInfo();
            Console.WriteLine("Shape added!");
        }
        private void AddCircle()
        {
            Console.WriteLine("Circle information");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle c = new Circle(name, radius);
            listShapes.Add(c);
            c.ShowInfo();
            Console.WriteLine("Shape added!");
        }
        private void ShowAllShapes()
        {
            foreach(Shape shape in listShapes)
            {
                shape.ShowInfo();
            }
        }
    }
}