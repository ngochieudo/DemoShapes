using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class Square : Rectangle
    {
        public Square() : base("Square", 2, 2)
        {

        }
        public Square(string name, int side) : base(name, side, side)
        {
            
        }
    }
}