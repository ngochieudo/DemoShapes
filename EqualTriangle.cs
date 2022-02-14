using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class EqualTriangle : Triangle
    {
        public EqualTriangle() : base("Equal Triangle", 2, 2, 2)
        {

        }
        public EqualTriangle(string name, int side) : base(name, side, side, side)
        {
            
        }
    }
}