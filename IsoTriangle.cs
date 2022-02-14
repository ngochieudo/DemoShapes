using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class IsoTriangle : Triangle
    {
        public IsoTriangle() : base("Iso Triangle", 2, 2, 5) {}
        public IsoTriangle(string name, int side, int bottom) : base(name, side, side, bottom)
        {
            
        } 
    }
}